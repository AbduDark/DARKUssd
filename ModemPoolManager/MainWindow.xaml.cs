using System.Windows;
using System.Windows.Controls;
using ModemPoolManager.ViewModels;

namespace ModemPoolManager;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        DataContext = new MainViewModel();
    }

    private void CopyOtpButton_Click(object sender, RoutedEventArgs e)
    {
        if (sender is Button button && button.Tag is string otp && !string.IsNullOrEmpty(otp))
        {
            try
            {
                Clipboard.SetText(otp);
                if (DataContext is MainViewModel vm)
                {
                    vm.StatusMessage = $"✓ تم نسخ رمز OTP: {otp}";
                }
            }
            catch (Exception ex)
            {
                if (DataContext is MainViewModel vm)
                {
                    vm.StatusMessage = $"✗ فشل نسخ OTP: {ex.Message}";
                }
            }
        }
    }
}
