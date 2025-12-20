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

### 🆕 Worker-Based Modem Architecture (December 2025)

**NEW CLASSES ADDED:**
- **ModemWorker.cs** - Manages a single modem with its own isolated worker:
  - One dedicated SerialPort per worker
  - One bounded command queue (size=1, auto-drops old jobs)
  - Sequential command execution per modem (no race conditions)
  - Automatic recovery on disconnect
  - Full CancellationToken support
  
- **ModemManager.cs** - Orchestrates multiple ModemWorker instances:
  - Supports up to 20 parallel modems
  - Broadcasts commands to all modems simultaneously
  - Worker lifecycle management
  - Clean parallel/sequential execution model
  
- **UssdJob.cs** - USSD execution job record with cancellation support

**Key Improvements:**
- ❌ Removed: Shared SerialPort instances (caused race conditions)
- ❌ Removed: SemaphoreSlim locks on ports (bottleneck for scaling)
- ✅ Added: One worker thread per modem (true isolation)
- ✅ Added: Bounded queue with auto-drop (prevents command buildup)
- ✅ Added: Automatic USSD cancellation (AT+CUSD=2) before new commands
- ✅ Added: Support for 20+ modems with 24/7 stability

**Integration Example:**
See `ModemManagerIntegration.cs` for usage patterns to refactor MainViewModel.

### UI/UX Decisions
The application uses WPF with the MVVM pattern (CommunityToolkit.Mvvm). Modems are displayed as individual cards in a `UniformGrid` (4x3 layout), featuring real-time information, animated loading circles, and color-coded elements. Phone numbers are color-coded by network operator. The theme is pure black (#000000) with dark card backgrounds (#0D0D0D) and operator-colored accents for borders and selected tab underlines. A `SignalBarsToOpacityConverter` provides visual signal strength feedback.

**Recent UI Updates (December 2025):**
- **Fullscreen Mode:** Application now launches in fullscreen (Maximized) with a custom close button (X) in the top-right corner for clean, immersive experience.
- **Increased Font Sizes:** All text sizes increased for better readability: USSD responses (16px), SMS messages (16px), Logs (15px), OTP headers (14px).
- **Operations Status Bar:** The main header now displays a dynamic operations status bar showing active background tasks (e.g., "جاري فحص المودمات", "جاري تنفيذ *100#"). Shows "جاهز للعمل" when idle with an animated spinner during active operations. Connected count displayed as a compact badge on the left.
- **Modem Card Redesign:** Phone number now prominently displayed in the center (32px font, bold). Action buttons (SMS, Signal refresh, Phone refresh, Reset) moved to the card footer for a cleaner layout. Checkbox on left, signal bars on right in header. Better visual hierarchy with less clutter.
- **OTP with Auto Passwords:** OtpService now automatically uses operator-specific cash passwords from Settings (Orange, Vodafone, Etisalat) - no need to enter password manually.

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
- **Orange Cash Parallel Transfer System:** Dedicated tab for parallel transfers (6 senders to 6 receivers) with balance inquiry, automatic pairing, real-time status, and color-coded results (orange for success, red for failure). Success detection includes "تم تحويل" pattern.
- **OC Series Tab (تحويل متسلسل):** Sequential Orange Cash transfers from multiple modems to a single target, with configurable delays and detailed logging.
- **TXT Transfer Tab (تحويل TXT):** Batch transfers from TXT/CSV files, with fixed amount mode, auto-summary, cash balance query, and local balance tracking. Transfer results are color-coded directly in the recipient list: green background for successful transfers, red background for failed transfers.
  - **Multiple Senders (December 2025):** Use the "+" button to add multiple sender numbers. Transfers are distributed across all active senders in parallel for faster processing. Each sender works independently, significantly speeding up batch transfers.
- **OTP Generation Tab (🔐 OTP السحب):** Generates ATM withdrawal OTPs using operator-specific USSD/SMS workflows (Vodafone, Orange, Etisalat) with real-time countdowns and session management.
- **Modem Card Enhancements:** Increased phone number font size, reset button, and right-click context menu for actions like restarting or copying phone numbers.
- **Automatic Validity Renewal (صلاحية الخطوط):** Global setting in Settings tab. When enabled, the system automatically sends SMS to 2656 upon modem connection to renew line validity. A checkmark (✅) appears on modem cards when renewal is successful.
- **Centralized Cash Passwords:** Settings tab contains separate password fields for Orange, Vodafone, and Etisalat networks. Passwords are automatically used based on the modem's operator.
- **TXT Transfer Progress:** Real-time progress display showing completed/total transfers and estimated time remaining during batch transfers.
- **Get Missed Feature (🔍 Get Missed):** Detects and auto-restarts modems that have failed or disconnected. Uses parallel execution for fast recovery.
- **Authorization Indicator (✓):** A green checkmark appears in the modem card USSD response area when a line gets successful USSD authorization response.
- **Batch USSD Execution (⚡):** Multi-code batch execution panel supporting up to 5 USSD codes executed sequentially on all selected modems. Each batch creates a new session ID for tracking.
- **Internet Toggle (📶):** Toggle button on each modem card to enable/disable mobile data using AT+CGATT and AT+CGACT commands.
- **Control Panel Toggle (👁):** Button to show/hide the main control panel for a cleaner interface when needed.
- **Operator Selection Filter (December 2025):** New setting in Settings tab to select a specific operator (Orange, Vodafone, Etisalat, or All). When a specific operator is selected:
  - Only tabs relevant to that operator are shown (e.g., Orange Cash tabs only appear when Orange is selected)
  - Phone number retrieval uses the selected operator's USSD code instead of auto-detecting the operator
  - This is useful when working exclusively with one operator's SIM cards

## External Dependencies
-   **.NET 8.0:** Application Framework.
-   **WPF (Windows Presentation Foundation):** User Interface Framework.
-   **CommunityToolkit.Mvvm:** MVVM Library for WPF.
-   **System.IO.Ports:** For COM port communication.
-   **System.Management:** For WMI queries to discover modems.
-   **OpenAI API:** For AI functionalities (USSD analysis, command suggestions, diagnostics, message analysis).