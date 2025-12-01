# Modem Pool Manager Pro - مدير المودمات الاحترافي

## ⚠️ ملاحظة هامة - Windows-Only Application
هذا البرنامج مصمم حصرياً للعمل على **Windows فقط** لأنه يعتمد على:
- **WPF** (Windows Presentation Foundation) للواجهة الرسومية
- **System.IO.Ports** للاتصال بمنافذ COM ports
- **System.Management** للبحث عن أجهزة ZTE عبر WMI

**على Replit (Linux):**
- ✅ يمكن تطوير وتحرير الكود
- ✅ يمكن بناء المشروع (build)
- ❌ لا يمكن تشغيل واختبار التطبيق
- ❌ لا يمكن الوصول إلى COM ports أو WMI
- ❌ لا يمكن عرض واجهة WPF

**للتشغيل والاختبار الفعلي:** يجب استخدام جهاز Windows مع مودمات ZTE متصلة

## نظرة عامة
برنامج C# WPF احترافي لإدارة مودمات متعددة (حتى 12 مودم) وتنفيذ أوامر USSD/SMS بشكل متزامن مع دعم الذكاء الاصطناعي.

## التقنيات المستخدمة
- **اللغة**: C# 12
- **الإطار**: .NET 8.0
- **الواجهة**: WPF (Windows Presentation Foundation)
- **النمط**: MVVM (Model-View-ViewModel)
- **مكتبة MVVM**: CommunityToolkit.Mvvm
- **الذكاء الاصطناعي**: OpenAI API

## الميزات الرئيسية

### 1. إدارة المودمات
- اكتشاف تلقائي للمودمات (ZTE Diagnostics Interface)
- دعم حتى 12 مودم متصل
- جلب معلومات تفصيلية (IMEI, IMSI, ICCID, Signal, Operator)
- تنفيذ أوامر متزامن (Parallel Execution)

### 2. أوامر USSD
- تنفيذ أوامر USSD على جميع المودمات
- أوامر سريعة قابلة للتخصيص
- فك تشفير الردود (GSM-7 & UCS-2)

### 3. الرسائل SMS
- إرسال رسائل SMS
- استقبال وقراءة الرسائل
- حذف الرسائل
- دعم Text Mode و PDU Mode

### 4. الذكاء الاصطناعي
- تحليل ردود USSD تلقائياً
- اقتراح أوامر مناسبة
- تشخيص مشاكل المودمات
- تحليل الرسائل

### 5. الإحصائيات والسجلات
- لوحة إحصائيات شاملة
- سجل الأوامر المنفذة
- تتبع نجاح/فشل العمليات

### 6. الإعدادات
- إعدادات المودم (Baud Rate, Timeout, Retries)
- إعدادات الذكاء الاصطناعي
- إعدادات الواجهة
- حفظ الإعدادات في JSON

## هيكل المشروع
```
ModemPoolManager/
├── Models/
│   ├── Modem.cs              # نموذج المودم
│   ├── ModemInfo.cs          # معلومات تفصيلية للمودم
│   ├── UssdResult.cs         # نتيجة USSD
│   ├── SmsMessage.cs         # نموذج الرسالة
│   ├── CommandHistory.cs     # سجل الأوامر
│   └── AppSettings.cs        # الإعدادات
├── Services/
│   ├── ModemService.cs       # خدمة إدارة المودمات
│   ├── SmsService.cs         # خدمة الرسائل
│   └── AiAssistantService.cs # خدمة الذكاء الاصطناعي
├── ViewModels/
│   └── MainViewModel.cs      # ViewModel الرئيسي
├── Converters/
│   └── InverseBoolConverter.cs
├── MainWindow.xaml           # الواجهة الرئيسية
├── MainWindow.xaml.cs
├── App.xaml
└── App.xaml.cs
```

## أوامر AT المدعومة

| الأمر | الوصف |
|-------|-------|
| AT | اختبار الاتصال |
| AT+CGSN | جلب IMEI |
| AT+CIMI | جلب IMSI |
| AT+CCID | جلب ICCID |
| AT+CGMI | جلب الشركة المصنعة |
| AT+CGMM | جلب الموديل |
| AT+CGMR | جلب الفيرموير |
| AT+CPIN? | حالة SIM |
| AT+CREG? | حالة التسجيل |
| AT+CSQ | قوة الإشارة |
| AT+COPS? | اسم المشغل |
| AT+CNUM | رقم الهاتف |
| AT+CUSD | تنفيذ USSD |
| AT+CMGF | وضع SMS |
| AT+CMGS | إرسال SMS |
| AT+CMGL | قائمة الرسائل |
| AT+CMGR | قراءة رسالة |
| AT+CMGD | حذف رسالة |
| AT+CFUN | إعادة تشغيل المودم |

## ملاحظة مهمة
هذا البرنامج يعمل فقط على Windows لأن WPF خاص بـ Windows.

## طريقة البحث عن المودمات
يبحث البرنامج عن المودمات باستخدام WMI Query مثل الكود القديم:
- **Query**: `SELECT * FROM Win32_PnPEntity` من `root\CIMV2`
- يبحث عن الأجهزة التي تحتوي على اسم معين
- يستخرج رقم البورت من اسم الجهاز (مثل: `ZTE NMEA Device (COM5)` → `COM5`)

### المنافذ المدعومة:
| نوع الجهاز | مثال | الأولوية |
|-----------|------|----------|
| ZTE NMEA Device | `ZTE NMEA Device (COM5)` | ✅ أولوية أولى (متوافق مع الكود القديم) |
| ZTE Diagnostics Interface | `ZTE Diagnostics Interface (COM5)` | ✅ أولوية ثانية |

### طريقة استخراج البورت:
```
Device Name: "ZTE NMEA Device (COM5)"
1. إزالة اسم الجهاز: "ZTE NMEA Device"
2. إزالة الأقواس: "()" 
3. إزالة المسافات
4. النتيجة: "COM5"
```

### المنافذ المستبعدة:
| نوع الجهاز | السبب |
|-----------|------|
| ZTE Application Interface | منفذ تطبيقات فقط |

## طريقة التشغيل
```bash
cd ModemPoolManager
dotnet restore
dotnet run
```

## التحديثات الأخيرة
- تصميم واجهة احترافي جديد (GitHub Dark Theme)
- دعم SMS كامل
- مساعد ذكي مدمج
- لوحة إحصائيات
- سجل الأوامر
- نظام إعدادات متكامل

## المراقبة التفاعلية (جديد)
البرنامج الآن يراقب المودمات تلقائياً:

### الميزات:
- **اكتشاف تلقائي**: عند توصيل مودم جديد يظهر فوراً في القائمة
- **عرض الرقم والإشارة**: يجلب رقم الخط وقوة الإشارة تلقائياً
- **كشف الفصل**: عند فصل المودم يظهر "تم الفصل ❌"
- **تحديث دوري**: يحدث حالة الإشارة كل 5 ثواني

### كيف يعمل:
1. عند بدء البرنامج تبدأ المراقبة التلقائية
2. يراقب قسم Ports (COM & LPT) لاكتشاف الأجهزة الجديدة
3. يبحث عن "ZTE NMEA Device" أو "ZTE Diagnostics Interface"
4. يجلب المعلومات (رقم الخط، الإشارة، المشغل) تلقائياً
5. عند فصل المودم يكتشف ذلك ويحدث الواجهة
6. عند إعادة توصيل المودم يحدث المعلومات تلقائياً

## التحديثات (آخر تحديث)
- تحديث طريقة البحث لتتوافق مع الكود القديم VB.NET
- دعم "ZTE NMEA Device" بالإضافة لـ "ZTE Diagnostics Interface"
- استخدام WMI Query: `SELECT * FROM Win32_PnPEntity`
- إصلاح مشكلة إعادة التوصيل (تحديث IsConnected)

## تحديث الواجهة الجديد (ديسمبر 2025)
### التصميم الجديد للمودمات:
- **كروت صغيرة لكل مودم** (320x280 بكسل) في شكل WrapPanel
- **دوائر تحميل متحركة** تظهر أثناء تنفيذ الأوامر
- **رقم الهاتف ملون حسب الشبكة**:
  - Vodafone/فودافون: أحمر
  - Orange/اورنج: برتقالي
  - Etisalat/اتصالات: أخضر
  - WE/وي: بنفسجي
  - STC: بنفسجي داكن
  - Mobily: أزرق سماوي
  - Zain: أخضر فاتح
- **عرض وقت التنفيذ** في أسفل كل كارت
- **عرض الرد** في منتصف الكارت مع التمرير
- **عداد النجاح والفشل** لكل مودم

### الملفات المحدثة:
- `ModemPoolManager/Models/Modem.cs` - إضافة LastResponseDuration و LastResponseTime
- `ModemPoolManager/Converters/OperatorToBrushConverter.cs` - محول لتلوين الأرقام حسب الشبكة
- `ModemPoolManager/MainWindow.xaml` - التصميم الجديد بالكامل (12 مودم في شبكة 4×3)
- `ModemPoolManager/ViewModels/MainViewModel.cs` - تتبع وقت التنفيذ لكل مودم
- `ModemPoolManager/Services/ModemService.cs` - تحسين إعادة الاتصال

## إصلاح مشكلة إعادة التوصيل (ديسمبر 2025)
### المشكلة:
عند فصل المودم وإعادة توصيله، البرنامج لم يكن يكتشفه مرة أخرى.

### الحل:
1. **إضافة دالة CleanupPort**: تقوم بتنظيف SerialPort والـ Lock عند فصل المودم
2. **تحسين TestPortConnectionAsync**: يتحقق من حالة البورت القديم ويحاول إعادة فتحه
3. **إضافة ForceRescanAsync**: إعادة فحص شاملة تمسح كل البيانات القديمة
4. **تحسين RefreshPortsAsync**: يستخدم ForceRescanAsync لإعادة الفحص الكامل

### كيف يعمل الآن:
1. عند فصل المودم → يتم تنظيف الـ SerialPort والـ Lock بالكامل
2. عند إعادة التوصيل → البرنامج ينشئ اتصال جديد نظيف
3. زر "تحديث" → يقوم بإعادة فحص كاملة مع تنظيف كل الاتصالات القديمة

## تحسين قراءة ردود USSD (ديسمبر 2025)
### المشكلة السابقة:
كان البرنامج يتوقف عند أول رد "OK" ولا ينتظر رد USSD الكامل الذي يأتي كـ unsolicited response.

### الحل الجديد:
تم إضافة دالة `SendUssdCommandAsync` متخصصة لأوامر USSD:

#### خطوات العمل:
1. **إرسال الأمر**: `AT+CUSD=1,"كود USSD",15`
2. **الاستماع المستمر**: البقاء في وضع الاستقبال لكامل المدة المحددة (10 ثواني افتراضياً)
3. **تجاهل OK المبكر**: لا يتوقف عند استلام OK بل يستمر في الاستماع
4. **التقاط +CUSD فوري**: عند ظهور سطر يحتوي على `+CUSD:` يتم طباعته فوراً في الـ Console
5. **التقاط ردود متعددة**: يمكن التقاط أكثر من رد USSD خلال فترة الانتظار
6. **التوقف عند الخطأ فقط**: يتوقف فوراً فقط إذا وصل ERROR من المودم
7. **معالجة عدم الرد**: إذا لم يصل أي رد +CUSD خلال فترة الانتظار يطبع `No USSD response received`

#### الدوال المحدثة:
- `SendUssdCommandAsync(portName, command, ussdWaitTimeSeconds)` - دالة جديدة متخصصة لـ USSD
- `ExecuteUssdAsync(modem, ussdCode, ussdWaitTimeSeconds)` - تستخدم الآن الدالة الجديدة
- `SendUssdCommandPublicAsync(portName, ussdCode, ussdWaitTimeSeconds)` - واجهة عامة للاستخدام الخارجي

#### مثال على الاستخدام:
```csharp
// تنفيذ USSD مع انتظار 10 ثواني (افتراضي)
var result = await modemService.ExecuteUssdAsync(modem, "*100#");

// تنفيذ USSD مع انتظار مخصص (15 ثانية)
var result = await modemService.ExecuteUssdAsync(modem, "*100#", 15);

// استخدام الدالة العامة مباشرة
var response = await modemService.SendUssdCommandPublicAsync("COM5", "*100#", 10);
```

#### تتبع العمليات (Console Output):
```
[COM5] إرسال: AT+CUSD=1,"*100#",15
[COM5] بدء الاستماع لمدة 10 ثانية...
[COM5] OK استلم بعد 0.3 ثانية - الاستمرار في الاستماع لمدة 9.7 ثانية إضافية...
[COM5] +CUSD: +CUSD: 0,"رصيدك هو 100 جنيه",15
[COM5] انتهت فترة الاستماع بعد 10.0 ثانية
[COM5] تم استلام 1 رد(ود) USSD:
  → +CUSD: 0,"رصيدك هو 100 جنيه",15
```

#### في حالة عدم وصول رد:
```
[COM5] إرسال: AT+CUSD=1,"*100#",15
[COM5] بدء الاستماع لمدة 10 ثانية...
[COM5] OK استلم بعد 0.2 ثانية - الاستمرار في الاستماع لمدة 9.8 ثانية إضافية...
[COM5] انتهت فترة الاستماع بعد 10.0 ثانية
[COM5] No USSD response received
```
