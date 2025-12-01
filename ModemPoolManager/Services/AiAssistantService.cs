using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using ModemPoolManager.Models;

namespace ModemPoolManager.Services;

public class AiAssistantService : IDisposable
{
    private readonly HttpClient _httpClient;
    private readonly AppSettings _settings;

    public AiAssistantService(AppSettings settings)
    {
        _settings = settings;
        _httpClient = new HttpClient();
        _httpClient.Timeout = TimeSpan.FromSeconds(60);
    }

    public bool IsEnabled => _settings.Ai.Enabled && !string.IsNullOrEmpty(_settings.Ai.ApiKey);

    public async Task<string> AnalyzeUssdResponseAsync(string ussdCode, string response, string operatorName)
    {
        if (!IsEnabled) return string.Empty;

        var prompt = $@"أنت مساعد ذكي متخصص في تحليل ردود USSD للمودمات.
قم بتحليل الرد التالي واستخرج المعلومات المهمة بشكل مختصر:

كود USSD: {ussdCode}
المشغل: {operatorName}
الرد: {response}

قدم:
1. ملخص قصير للرد
2. أي أرقام أو أرصدة مهمة
3. أي إجراءات مقترحة";

        return await SendChatRequestAsync(prompt);
    }

    public async Task<string> SuggestUssdCommandsAsync(string operatorName, string purpose)
    {
        if (!IsEnabled) return string.Empty;

        var prompt = $@"أنت مساعد ذكي متخصص في أكواد USSD.
المشغل: {operatorName}
الغرض: {purpose}

اقترح أكواد USSD مناسبة مع شرح كل كود.
قدم الأكواد الأكثر شيوعاً فقط (3-5 أكواد).";

        return await SendChatRequestAsync(prompt);
    }

    public async Task<string> DiagnoseModemIssueAsync(string errorMessage, string lastCommands)
    {
        if (!IsEnabled) return string.Empty;

        var prompt = $@"أنت مساعد ذكي متخصص في تشخيص مشاكل المودمات.

رسالة الخطأ: {errorMessage}
آخر الأوامر المنفذة: {lastCommands}

قم بـ:
1. تحديد سبب المشكلة المحتمل
2. اقتراح خطوات الحل
3. أوامر AT للتشخيص";

        return await SendChatRequestAsync(prompt);
    }

    public async Task<string> AnalyzeSmsAsync(string smsContent)
    {
        if (!IsEnabled) return string.Empty;

        var prompt = $@"قم بتحليل محتوى هذه الرسالة النصية واستخراج المعلومات المهمة:

{smsContent}

استخرج:
1. نوع الرسالة (إعلان، تأكيد، رصيد، إلخ)
2. المعلومات المهمة
3. أي إجراء مطلوب";

        return await SendChatRequestAsync(prompt);
    }

    public async Task<ModemHealthReport> AnalyzeModemHealthAsync(Modem modem)
    {
        var report = new ModemHealthReport
        {
            ModemIndex = modem.Index,
            AnalysisTime = DateTime.Now
        };

        if (modem.Info.SignalPercent < 30)
        {
            report.Issues.Add("إشارة ضعيفة");
            report.Recommendations.Add("تحقق من موقع المودم أو الهوائي");
        }

        if (modem.FailedCommands > modem.SuccessfulCommands && modem.FailedCommands > 5)
        {
            report.Issues.Add("نسبة فشل عالية");
            report.Recommendations.Add("إعادة تشغيل المودم أو التحقق من الاتصال");
        }

        if (modem.Info.SimStatus != "READY" && !string.IsNullOrEmpty(modem.Info.SimStatus))
        {
            report.Issues.Add($"حالة SIM غير طبيعية: {modem.Info.SimStatus}");
            report.Recommendations.Add("تحقق من بطاقة SIM");
        }

        report.HealthScore = CalculateHealthScore(modem);
        report.Status = report.HealthScore > 80 ? "ممتاز" :
                        report.HealthScore > 60 ? "جيد" :
                        report.HealthScore > 40 ? "متوسط" : "ضعيف";

        return report;
    }

    private int CalculateHealthScore(Modem modem)
    {
        int score = 100;

        score -= (100 - (int)modem.Info.SignalPercent) / 2;

        if (modem.SuccessfulCommands + modem.FailedCommands > 0)
        {
            var successRate = (double)modem.SuccessfulCommands / (modem.SuccessfulCommands + modem.FailedCommands);
            score -= (int)((1 - successRate) * 30);
        }

        if (modem.Info.SimStatus != "READY" && !string.IsNullOrEmpty(modem.Info.SimStatus))
        {
            score -= 20;
        }

        if (modem.Info.IsRoaming)
        {
            score -= 10;
        }

        return Math.Max(0, Math.Min(100, score));
    }

    private async Task<string> SendChatRequestAsync(string prompt)
    {
        if (string.IsNullOrEmpty(_settings.Ai.ApiKey))
        {
            return "⚠️ مفتاح API غير محدد. يرجى إدخاله في الإعدادات.";
        }

        try
        {
            _httpClient.DefaultRequestHeaders.Clear();
            _httpClient.DefaultRequestHeaders.Add("Authorization", $"Bearer {_settings.Ai.ApiKey}");

            var requestBody = new
            {
                model = _settings.Ai.Model,
                messages = new[]
                {
                    new { role = "system", content = "أنت مساعد ذكي متخصص في إدارة المودمات وأوامر AT و USSD. أجب باللغة العربية بشكل مختصر ومفيد." },
                    new { role = "user", content = prompt }
                },
                max_tokens = _settings.Ai.MaxTokens,
                temperature = _settings.Ai.Temperature
            };

            var json = JsonSerializer.Serialize(requestBody);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            using var cts = new CancellationTokenSource(TimeSpan.FromSeconds(30));
            var response = await _httpClient.PostAsync("https://api.openai.com/v1/chat/completions", content, cts.Token).ConfigureAwait(false);
            
            if (response.IsSuccessStatusCode)
            {
                var responseJson = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                using var doc = JsonDocument.Parse(responseJson);
                
                return doc.RootElement
                    .GetProperty("choices")[0]
                    .GetProperty("message")
                    .GetProperty("content")
                    .GetString() ?? string.Empty;
            }
            else
            {
                return $"⚠️ خطأ من الخادم: {response.StatusCode}";
            }
        }
        catch (TaskCanceledException)
        {
            return "⚠️ انتهت مهلة الطلب. تحقق من اتصال الإنترنت.";
        }
        catch (HttpRequestException ex)
        {
            return $"⚠️ خطأ في الاتصال: {ex.Message}";
        }
        catch (Exception ex)
        {
            return $"⚠️ خطأ: {ex.Message}";
        }
    }

    public void Dispose()
    {
        _httpClient.Dispose();
    }
}

public class ModemHealthReport
{
    public int ModemIndex { get; set; }
    public DateTime AnalysisTime { get; set; }
    public int HealthScore { get; set; }
    public string Status { get; set; } = string.Empty;
    public List<string> Issues { get; set; } = new();
    public List<string> Recommendations { get; set; } = new();
}
