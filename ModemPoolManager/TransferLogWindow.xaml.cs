using System.Collections.ObjectModel;
using System.Windows;
using ModemPoolManager.Models;

namespace ModemPoolManager
{
    public partial class TransferLogWindow : Window
    {
        public TransferLogWindow(string logContent, ObservableCollection<TransferLogEntry>? transferEntries = null)
        {
            InitializeComponent();
            LogTextBlock.Text = string.IsNullOrEmpty(logContent) ? "لا توجد سجلات حتى الآن" : logContent;
            
            if (transferEntries != null && transferEntries.Count > 0)
            {
                TransferEntriesControl.ItemsSource = transferEntries;
            }
        }

        private void CopyLog_Click(object sender, RoutedEventArgs e)
        {
            var fullLog = "";
            
            if (TransferEntriesControl.ItemsSource is ObservableCollection<TransferLogEntry> entries)
            {
                foreach (var entry in entries)
                {
                    var status = entry.IsSuccess ? "✓ نجح" : "✗ فشل";
                    fullLog += $"{entry.PhoneNumber}: {status} - {entry.Message}\n";
                }
                fullLog += "\n";
            }
            
            fullLog += LogTextBlock.Text;
            
            if (!string.IsNullOrEmpty(fullLog))
            {
                Clipboard.SetText(fullLog);
                MessageBox.Show("تم نسخ السجل إلى الحافظة", "نسخ", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        private void Close_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
