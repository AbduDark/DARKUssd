# Modem Pool Manager Pro - مدير المودمات الاحترافي

## Overview
Modem Pool Manager Pro is a professional C# WPF application designed to manage multiple modems (up to 12) for concurrent USSD/SMS operations, enhanced with AI capabilities. The project aims to provide a robust solution for businesses requiring large-scale modem interaction, offering automatic modem detection, detailed information retrieval, and intelligent response analysis. It is a Windows-only application, leveraging WPF for the UI and Windows-specific functionalities for COM port communication and modem discovery.

## User Preferences
- **Coding Style:** I prefer clean, maintainable C# code.
- **Workflow:** I appreciate an iterative development approach.
- **Communication:** Please explain complex topics in clear, simple language.
- **Interaction:** Ask for confirmation before making significant architectural changes or adding new external dependencies.
- **Focus:** Prioritize features that enhance performance and reliability in a multi-modem environment.
- **UI/UX:** Adhere to the specified UI/UX design decisions, especially the card-based modem display and color-coded information.

## System Architecture

### UI/UX Decisions
-   **Main Interface:** WPF (Windows Presentation Foundation) with MVVM (Model-View-ViewModel) pattern using CommunityToolkit.Mvvm.
-   **Modem Display:** Individual modem cards (320x280 pixels) arranged in a `WrapPanel`.
-   **Visual Feedback:** Animated loading circles during command execution.
-   **Color Coding:** Phone numbers are color-coded based on the network operator (e.g., Vodafone: red, Orange: orange, Etisalat: green).
-   **Real-time Information:** Display of execution time, USSD/SMS responses (scrollable), and success/failure counters per modem.
-   **Signal Strength Indicator:** Uses `SignalBarsToOpacityConverter` for a visually progressive signal strength display.
-   **Theming:** GitHub Dark Theme.

### Technical Implementations
-   **Modem Management:**
    -   Automatic detection of ZTE modems (ZTE NMEA Device, ZTE Diagnostics Interface) via WMI queries (`SELECT * FROM Win32_PnPEntity`).
    -   Support for up to 12 connected modems.
    -   Parallel execution of commands.
    -   Robust reconnection logic with `CleanupPort`, `TestPortConnectionAsync`, `ForceRescanAsync`, and `RefreshPortsAsync` for reliable modem re-detection after disconnection.
    -   Interactive monitoring: auto-detection of new modems, display of phone number and signal strength, disconnection detection, and 5-second signal updates.
    -   **Auto-remove modem from UI when disconnected:** Modem card disappears immediately when device is unplugged.
    -   **Auto-fetch phone number on connection:** Phone number is retrieved automatically using USSD codes when modem is connected.
    -   **Improved reconnection handling:** When modem is unplugged and replugged, old port resources are cleaned up and new connection is established automatically via WMI event watchers.
    -   **Robust refresh button:** ForceRescanAsync now properly cleans all port resources (persistent ports, locks) before rescanning.
-   **Fast phone number retrieval:** Uses the same USSD-direct approach as the old VB.NET system - sends operator-specific USSD codes (*878# for Vodafone, #119*1# for Orange, *947# for Etisalat) directly without trying AT+CNUM first. Operator and signal are fetched in parallel, then phone number is retrieved via USSD with 6-second timeout.
-   **Auto-retry phone number retrieval:** When a phone number is unknown ("غير معروف"), the system automatically retries fetching it every 5 seconds using operator-specific USSD codes:
    -   Vodafone: `*878#`
    -   Orange: `#119*1#`
    -   Etisalat: `*947#`
    -   WE: `*999#`
-   **MF626 Modem Support:** Added explicit detection patterns for ZTE MF626 modems in GetZTEDiagnosticsPorts.
-   **Improved Modem Restart:** RestartModemAsync now properly acquires port locks, disposes cached ports, uses AT+CFUN=0/1 sequence with AT^RESET fallback, and verifies reconnection via polling.
-   **Network Mode Management:**
    -   Automatic network mode setting based on operator: Vodafone = 2G only, all other operators = 3G only.
    -   Uses AT+ZSNT command with fallback to AT^SYSCFG for broader modem compatibility.
    -   Verifies network mode after setting and displays current mode in modem info.
-   **USSD Commands:**
    -   Specialized `SendUssdCommandAsync` for reliable USSD response capture, handling unsolicited responses and multiple replies.
    -   Decoding of USSD responses (GSM-7 & UCS-2).
    -   Quick, customizable USSD commands.
    -   Fallback mechanism for phone number retrieval using network-specific USSD codes if `AT+CNUM` fails.
-   **SMS Messaging:**
    -   Send, receive, read, and delete SMS messages.
    -   Support for Text Mode and PDU Mode.
-   **AT Command Handling:** Improved AT command parsing to prevent premature termination of responses by filtering `OK` for USSD commands.
-   **Phone Number Retrieval:** Enhanced `GetPhoneNumberWithUssdFallbackAsync` using multiple regex patterns for `AT+CNUM` and network-specific USSD codes.
-   **Configuration:** Settings are saved in JSON format.

### Core Features
-   **Wave 1 Features (All Visible in UI)**:
    -   Main Dashboard - modem management with USSD execution
    -   SMS - real-time message listening and management
    -   TopUp - parallel card charging across modems
    -   BalQry - balance query for all lines
    -   GrpBalQry - group balance query by operator with statistics
    -   Orange Cash - parallel transfers between sender/receiver pairs
-   Detailed modem information retrieval (IMEI, IMSI, ICCID, Signal, Operator).
-   AI-powered USSD response analysis, command suggestions, modem diagnostics, and message analysis.
-   Comprehensive statistics dashboard and command logging.
-   **Orange Cash Parallel Transfer System:**
    -   Dedicated tab for Orange Cash operations with 6 sender → 6 receiver parallel transfer pattern.
    -   Balance inquiry for all modems using USSD code `#7115*81*{password}#`.
    -   Parallel money transfers using USSD code `#7115*1*1*{phone}*{amount}*{password}#`.
    -   Automatic pairing: modems 1-6 as senders, modems 7-12 as receivers (1→7, 2→8, 3→9, 4→10, 5→11, 6→12).
    -   Real-time status display: "تم التحويل" for senders, "تم الاستلام" for receivers.
    -   8-second cooldown between transfer batches to prevent carrier blocking.
    -   Visual indicators: orange border for senders, green border for receivers.
    -   Transfer log with detailed operation history.
-   **OC Series Tab (تحويل متسلسل) - NEW:**
    -   Sequential Orange Cash transfers from multiple modems to a single target phone.
    -   Uses USSD code `#7115*1*1*{phone}*{amount}*{password}#` for transfers.
    -   Phone number retrieval via `#119*1#` USSD code.
    -   Configurable delay between transfers (default 12 seconds).
    -   Real-time countdown display during delays.
    -   Start/Stop controls with cancellation support.
    -   Detailed transfer log with success/failure tracking.
-   **Custom Transfer Tab (تحويل مخصص) - NEW:**
    -   Import transfer list from CSV files (phone,amount format).
    -   Single sender modem to multiple recipients.
    -   DataGrid display of pending transfers with status.
    -   Configurable delay between transfers.
    -   Progress tracking with countdown display.
    -   Start/Stop controls for batch processing.
-   **Modem Card Improvements:**
    -   Increased phone number font size to 18 for better visibility.
    -   Added Reset button next to phone refresh button for full modem reset (AT+CFUN=0/1).
-   **SMS Inbox Feature (NEW - Mobile-like design):**
    -   SMS button with unread count badge on each modem card.
    -   Click to open popup showing message list for that modem.
    -   Messages displayed with sender number, timestamp, and preview text.
    -   Click any message to view full details in a dialog.
    -   Uses SmsService.GetAllMessagesAsync for message retrieval.
    -   Integrated with SmsListenerService for real-time updates.
-   **Right-click Context Menu on Modem Cards:**
    -   Restart Modem (AT+CFUN=0/1 sequence).
    -   Copy Phone Number to clipboard.
    -   Refresh Signal and Phone Number.

### New Services (Wave 1-3 Implementation)
-   **RetryService (NEW):**
    -   Centralized automatic retry system for all operations.
    -   Configurable retry count (default: 3 retries).
    -   Exponential backoff between retries.
    -   Jitter to prevent thundering herd.
    -   Events for retry attempts, success, and failure.
    -   Integration with AppSettings for configuration.
-   **SmsListenerService (NEW):**
    -   Real-time SMS monitoring using CNMI (AT+CNMI=2,1,0,0,0).
    -   Polling-based fallback for older modems.
    -   Events for new message notifications.
    -   Automatic unread count tracking per modem.
    -   Automatic retry on send failure.
-   **BalanceQueryService (NEW):**
    -   Parallel balance queries for all modems.
    -   Operator-specific balance codes (Vodafone *868#, Orange *100#, Etisalat *102#, WE *550#).
    -   Extraction of main balance, bonus, data, and expiry date.
    -   Group balance statistics (total, average, success/failure counts).
    -   Automatic retry on query failure.
-   **CardTopUpService (NEW):**
    -   Parallel card charging across all modems.
    -   Operator-specific top-up codes (Vodafone *858*, Orange *110*, Etisalat *556*).
    -   Balance transfer between lines.
    -   Success/failure detection with error messages.
    -   Automatic retry on top-up failure.
-   **OcSeriesService (NEW):**
    -   Orange Cash sequential transfers with automatic retry.
    -   Chain transfer support (main line to multiple recipients).
    -   Real-time countdown between transfers.
    -   Detailed transfer logging.
-   **Sequential USSD with Reply Support:**
    -   IsReply checkbox for each command to distinguish between new USSD sessions and replies.
    -   Each modem gets a fresh USSD session (AT+CUSD=2 to cancel previous, then new command).
    -   Commands marked as "Reply" use SendUssdReplyAsync to continue in same session.
    -   Execution continues to next modem even if one modem fails.
    -   Visual indicator (orange badge) for reply commands in the UI.
-   **OperatorServicesManager (NEW):**
    -   Vodafone services: Flex balance, data remaining, power menu, master menu.
    -   Orange services: Internet bundles, Orange Cash operations, data remaining.
    -   Etisalat services: Internet bundles, call bundles, data remaining.
    -   Saved services management for custom USSD operations.

### Project Structure
-   **Models:** Data structures for Modems, ModemInfo, UssdResult, SmsMessage, BalanceResult, CardTopUpResult, TransferResult, CommandHistory, AppSettings.
-   **Services:** Business logic for ModemService, SmsService, SmsListenerService, BalanceQueryService, CardTopUpService, OcSeriesService, OperatorServicesManager, RetryService, AiAssistantService.
-   **ViewModels:** MainViewModel for UI logic.
-   **Converters:** UI utility converters (e.g., `InverseBoolConverter`, `OperatorToBrushConverter`, `SignalBarsToOpacityConverter`).
-   **Views:** `MainWindow.xaml` for the main user interface (all 17 tabs).

## External Dependencies
-   **.NET 8.0:** Application Framework.
-   **WPF (Windows Presentation Foundation):** User Interface Framework (Windows-only).
-   **CommunityToolkit.Mvvm:** MVVM Library.
-   **System.IO.Ports:** For COM port communication (Windows-only).
-   **System.Management:** For WMI queries to discover modems (Windows-only).
-   **OpenAI API:** For AI functionalities (USSD analysis, command suggestions, diagnostics, message analysis).