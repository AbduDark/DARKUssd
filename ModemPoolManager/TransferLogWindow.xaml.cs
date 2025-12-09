using System.Windows;

namespace ModemPoolManager
{
    public partial class TransferLogWindow : Window
    {
        public TransferLogWindow(string logContent)
        {
            InitializeComponent();
            LogTextBlock.Text = string.IsNullOrEmpty(logContent) ? "لا توجد سجلات حتى الآن" : logContent;
        }

        private void CopyLog_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(LogTextBlock.Text))
            {
                Clipboard.SetText(LogTextBlock.Text);
                MessageBox.Show("تم نسخ السجل إلى الحافظة", "نسخ", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        private void Close_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
