# Modem Pool Manager Pro - مدير المودمات الاحترافي

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
