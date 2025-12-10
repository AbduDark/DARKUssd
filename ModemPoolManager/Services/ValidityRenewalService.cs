using System.Windows;
using ModemPoolManager.Models;

namespace ModemPoolManager.Services;

public class ValidityRenewalService
{
    private readonly SmsService _smsService;
    private const string VALIDITY_RENEWAL_NUMBER = "2656";

    public event EventHandler<(Modem Modem, bool Success, string Message)>? OnRenewalCompleted;

    public ValidityRenewalService(SmsService smsService)
    {
        _smsService = smsService;
    }

    private void UpdateModemOnUiThread(Action action)
    {
        if (Application.Current?.Dispatcher != null)
        {
            Application.Current.Dispatcher.Invoke(action);
        }
        else
        {
            action();
        }
    }

    public async Task<bool> RenewValidityAsync(Modem modem)
    {
        if (string.IsNullOrEmpty(modem.PortName) || !modem.IsConnected)
        {
            UpdateModemOnUiThread(() => modem.ValidityStatus = "غير متصل");
            return false;
        }

        if (string.IsNullOrEmpty(modem.PhoneNumber) || modem.PhoneNumber == "غير معروف")
        {
            UpdateModemOnUiThread(() => modem.ValidityStatus = "رقم غير معروف");
            return false;
        }

        try
        {
            UpdateModemOnUiThread(() =>
            {
                modem.IsRenewingValidity = true;
                modem.ValidityStatus = "جاري التجديد...";
                modem.ValidityRenewed = false;
            });

            var phoneNumber = modem.PhoneNumber.Replace(" ", "").Trim();
            if (!phoneNumber.StartsWith("01"))
            {
                if (phoneNumber.StartsWith("+2"))
                    phoneNumber = phoneNumber.Substring(2);
                else if (phoneNumber.StartsWith("2"))
                    phoneNumber = phoneNumber.Substring(1);
            }

            var (success, error) = await _smsService.SendSmsAsync(
                modem.PortName, 
                VALIDITY_RENEWAL_NUMBER, 
                phoneNumber);

            if (success)
            {
                UpdateModemOnUiThread(() =>
                {
                    modem.ValidityRenewed = true;
                    modem.ValidityStatus = "✅ تم التجديد";
                });
                OnRenewalCompleted?.Invoke(this, (modem, true, "تم تجديد الصلاحية بنجاح"));
                return true;
            }
            else
            {
                UpdateModemOnUiThread(() => modem.ValidityStatus = $"❌ فشل: {error}");
                OnRenewalCompleted?.Invoke(this, (modem, false, error));
                return false;
            }
        }
        catch (Exception ex)
        {
            UpdateModemOnUiThread(() => modem.ValidityStatus = $"❌ خطأ: {ex.Message}");
            OnRenewalCompleted?.Invoke(this, (modem, false, ex.Message));
            return false;
        }
        finally
        {
            UpdateModemOnUiThread(() => modem.IsRenewingValidity = false);
        }
    }

    public async Task RenewAllEnabledAsync(IEnumerable<Modem> modems)
    {
        var tasks = modems
            .Where(m => m.AutoRenewValidity && m.IsConnected && !m.ValidityRenewed)
            .Select(m => RenewValidityAsync(m));

        await Task.WhenAll(tasks);
    }
}
