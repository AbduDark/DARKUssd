using System.Windows;
using System.Windows.Media;
using ModemPoolManager.Models;

namespace ModemPoolManager;

public partial class MessageDetailsWindow : Window
{
    private readonly SmsMessage _message;
    
    public bool DeleteRequested { get; private set; }
    public bool ReplyRequested { get; private set; }

    public MessageDetailsWindow(SmsMessage message, string? modemPhoneNumber = null)
    {
        InitializeComponent();
        _message = message;
        
        DataContext = new { OperatorName = GetOperatorFromNumber(message.PhoneNumber) };
        
        SenderNumber.Text = message.PhoneNumber;
        MessageDate.Text = message.Timestamp.ToString("yyyy/MM/dd - hh:mm:ss tt");
        
        var modemDisplay = $"مودم {message.ModemIndex + 1}";
        if (!string.IsNullOrEmpty(modemPhoneNumber) && modemPhoneNumber != "غير معروف")
        {
            modemDisplay += $" ({modemPhoneNumber})";
        }
        ModemInfo.Text = modemDisplay;
        
        MessageContent.Text = message.Message;
        
        SetStatusBadge(message.Status);
        
        if (message.HasOtp)
        {
            OtpSection.Visibility = Visibility.Visible;
            OtpCode.Text = message.ExtractedOtp;
        }
    }

    private void SetStatusBadge(SmsStatus status)
    {
        switch (status)
        {
            case SmsStatus.Unread:
                StatusBadge.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#238636"));
                StatusText.Text = "جديدة";
                StatusText.Foreground = Brushes.White;
                break;
            case SmsStatus.Read:
                StatusBadge.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#21262D"));
                StatusText.Text = "مقروءة";
                StatusText.Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#8B949E"));
                break;
            case SmsStatus.Sent:
                StatusBadge.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#1F6FEB"));
                StatusText.Text = "مرسلة";
                StatusText.Foreground = Brushes.White;
                break;
            case SmsStatus.Unsent:
                StatusBadge.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#D29922"));
                StatusText.Text = "غير مرسلة";
                StatusText.Foreground = Brushes.White;
                break;
            case SmsStatus.Failed:
                StatusBadge.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#DA3633"));
                StatusText.Text = "فشلت";
                StatusText.Foreground = Brushes.White;
                break;
        }
    }

    private string GetOperatorFromNumber(string phoneNumber)
    {
        if (string.IsNullOrEmpty(phoneNumber)) return "Unknown";
        
        var number = phoneNumber.Replace("+2", "").Replace("+", "").Replace(" ", "");
        
        if (number.StartsWith("010"))
            return "Vodafone";
        if (number.StartsWith("012"))
            return "Orange";
        if (number.StartsWith("011"))
            return "Etisalat";
        if (number.StartsWith("015"))
            return "WE";
            
        return "Unknown";
    }

    private void CopyMessage_Click(object sender, RoutedEventArgs e)
    {
        try
        {
            Clipboard.SetText(_message.Message);
            MessageBox.Show("تم نسخ نص الرسالة", "تم", MessageBoxButton.OK, MessageBoxImage.Information);
        }
        catch
        {
            MessageBox.Show("فشل في نسخ النص", "خطأ", MessageBoxButton.OK, MessageBoxImage.Error);
        }
    }

    private void CopyOtp_Click(object sender, RoutedEventArgs e)
    {
        try
        {
            if (_message.HasOtp)
            {
                Clipboard.SetText(_message.ExtractedOtp);
                MessageBox.Show($"تم نسخ كود التحقق: {_message.ExtractedOtp}", "تم", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }
        catch
        {
            MessageBox.Show("فشل في نسخ الكود", "خطأ", MessageBoxButton.OK, MessageBoxImage.Error);
        }
    }

    private void Reply_Click(object sender, RoutedEventArgs e)
    {
        ReplyRequested = true;
        DialogResult = true;
        Close();
    }

    private void Delete_Click(object sender, RoutedEventArgs e)
    {
        var result = MessageBox.Show("هل تريد حذف هذه الرسالة؟", "تأكيد الحذف", 
            MessageBoxButton.YesNo, MessageBoxImage.Question);
        
        if (result == MessageBoxResult.Yes)
        {
            DeleteRequested = true;
            DialogResult = true;
            Close();
        }
    }

    private void CloseButton_Click(object sender, RoutedEventArgs e)
    {
        DialogResult = false;
        Close();
    }

    protected override void OnMouseLeftButtonDown(System.Windows.Input.MouseButtonEventArgs e)
    {
        base.OnMouseLeftButtonDown(e);
        DragMove();
    }
}
