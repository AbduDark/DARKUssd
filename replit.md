# Modem Pool Manager Pro - مدير المودمات الاحترافي

## Overview
Modem Pool Manager Pro is a professional C# WPF application designed to manage up to 12 modems concurrently for USSD/SMS operations, enhanced with AI capabilities. Its purpose is to provide a robust, Windows-only solution for businesses requiring large-scale modem interaction, offering automatic modem detection, detailed information retrieval, and intelligent response analysis. The project aims to streamline multi-modem management, improve reliability, and provide advanced features for tasks like parallel money transfers and OTP generation.

## User Preferences
- **Coding Style:** I prefer clean, maintainable C# code.
- **Workflow:** I appreciate an iterative development approach.
- **Communication:** Please explain complex topics in clear, simple language.
- **Interaction:** Ask for confirmation before making significant architectural changes or adding new external dependencies.
- **Focus:** Prioritize features that enhance performance and reliability in a multi-modem environment.
- **UI/UX:** Adhere to the specified UI/UX design decisions, especially the card-based modem display and color-coded information.

## System Architecture

### UI/UX Decisions
The application uses WPF with the MVVM pattern (CommunityToolkit.Mvvm). Modems are displayed as individual cards (320x280 pixels) in a `WrapPanel`, featuring real-time information, animated loading circles, and color-coded elements. Phone numbers are color-coded by network operator. The theme is pure black (#000000) with dark card backgrounds (#0D0D0D) and operator-colored accents for borders and selected tab underlines. A `SignalBarsToOpacityConverter` provides visual signal strength feedback.

### Technical Implementations
- **Modem Management:** Supports up to 12 ZTE modems via WMI queries for automatic detection. Features parallel command execution, robust reconnection logic (cleaning up resources and re-detecting), and automatic removal of disconnected modems from the UI.
- **Force Cleanup & Rescan:** New `DisposeAllPorts()` and `ForceRescanAsync()` methods fix modem detection after frequent connect/disconnect cycles. Falls back to scanning all COM ports when ZTE NMEA WMI enumeration fails. Uses retry logic with exponential backoff for port testing.
- **Phone Number & Operator Retrieval:** Fast retrieval using operator-specific USSD codes (e.g., Vodafone `*878#`). Automatically retries fetching unknown numbers every 5 seconds.
- **Modem Control:** Improved modem restart (AT+CFUN=0/1) and network mode management (automatic 2G/3G setting based on operator using AT+ZSNT or AT^SYSCFG).
- **USSD Commands:** Reliable `SendUssdCommandAsync` for response capture, handling unsolicited responses, and decoding (GSM-7 & UCS-2). Supports sequential USSD commands with reply functionality.
- **SMS Messaging:** Capabilities to send, receive, read, and delete SMS messages in Text or PDU mode. Includes an SMS Inbox with unread count badge, message details view, and OTP extraction.
- **Persistent State:** All user inputs and application settings are automatically saved to `AppData/ModemPoolManager/appstate.json` and restored on launch.
- **Services:**
    -   `RetryService`: Centralized retry system with configurable counts, exponential backoff, and jitter.
    -   `SmsListenerService`: Real-time SMS monitoring via CNMI with polling fallback.
    -   `BalanceQueryService`: Parallel balance queries using operator-specific codes.
    -   `OcSeriesService`: Handles sequential Orange Cash transfers with retry logic.
    -   `ValidityRenewalService`: Automatic line validity renewal by sending SMS to 2656.

### Core Features
- **Main Dashboard:** Modem management with USSD execution.
- **SMS:** Message management.
- **Orange Cash Parallel Transfer System:** Dedicated tab for parallel transfers (6 senders to 6 receivers) with balance inquiry, automatic pairing, and real-time status.
- **OC Series Tab (تحويل متسلسل):** Sequential Orange Cash transfers from multiple modems to a single target, with configurable delays and detailed logging.
- **TXT Transfer Tab (تحويل TXT):** Batch transfers from TXT/CSV files, with fixed amount mode, auto-summary, cash balance query, and local balance tracking.
- **OTP Generation Tab (🔐 OTP السحب):** Generates ATM withdrawal OTPs using operator-specific USSD/SMS workflows (Vodafone, Orange, Etisalat) with real-time countdowns and session management.
- **Modem Card Enhancements:** Increased phone number font size, reset button, and right-click context menu for actions like restarting or copying phone numbers.
- **Automatic Validity Renewal (صلاحية الخطوط):** Each modem card has a "صلاحية" checkbox. When enabled, the system automatically sends SMS to 2656 upon modem connection to renew line validity. A checkmark (✅) appears when renewal is successful.

## External Dependencies
-   **.NET 8.0:** Application Framework.
-   **WPF (Windows Presentation Foundation):** User Interface Framework.
-   **CommunityToolkit.Mvvm:** MVVM Library for WPF.
-   **System.IO.Ports:** For COM port communication.
-   **System.Management:** For WMI queries to discover modems.
-   **OpenAI API:** For AI functionalities (USSD analysis, command suggestions, diagnostics, message analysis).