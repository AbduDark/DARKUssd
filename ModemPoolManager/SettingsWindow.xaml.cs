using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using ModemPoolManager.ViewModels;

namespace ModemPoolManager;

public partial class SettingsWindow : Window
{
    private readonly MainViewModel _viewModel;
    private string _originalBaudRate = "115200";
    private string _originalReadTimeout = "10000";
    private string _originalMaxModems = "12";
    private string _originalOrangeCashPassword = "";
    private string _originalVodafoneCashPassword = "";
    private string _originalEtisalatCashPassword = "";
    private bool _originalAutoRenewValidity;
    private string _originalSelectedOperator = "All";

    public SettingsWindow(MainViewModel viewModel)
    {
        InitializeComponent();
        _viewModel = viewModel;
        SaveOriginalValues();
        LoadSettings();
    }

    private void SaveOriginalValues()
    {
        _originalBaudRate = _viewModel.Settings?.Modem?.BaudRate.ToString() ?? "115200";
        _originalReadTimeout = _viewModel.Settings?.Modem?.ReadTimeout.ToString() ?? "10000";
        _originalMaxModems = _viewModel.Settings?.Modem?.MaxModems.ToString() ?? "12";
        _originalOrangeCashPassword = _viewModel.OrangeCashPassword ?? "";
        _originalVodafoneCashPassword = _viewModel.VodafoneCashPassword ?? "";
        _originalEtisalatCashPassword = _viewModel.EtisalatCashPassword ?? "";
        _originalAutoRenewValidity = _viewModel.AutoRenewValidityForAll;
        _originalSelectedOperator = _viewModel.SelectedOperator ?? "All";
    }

    private void LoadSettings()
    {
        BaudRateTextBox.Text = _originalBaudRate;
        ReadTimeoutTextBox.Text = _originalReadTimeout;
        MaxModemsTextBox.Text = _originalMaxModems;
        OrangeCashPasswordTextBox.Text = _originalOrangeCashPassword;
        VodafoneCashPasswordTextBox.Text = _originalVodafoneCashPassword;
        EtisalatCashPasswordTextBox.Text = _originalEtisalatCashPassword;
        AutoRenewValidityCheckBox.IsChecked = _originalAutoRenewValidity;
        
        foreach (ComboBoxItem item in OperatorComboBox.Items)
        {
            if (item.Tag?.ToString() == _originalSelectedOperator)
            {
                OperatorComboBox.SelectedItem = item;
                break;
            }
        }
        if (OperatorComboBox.SelectedItem == null)
        {
            OperatorComboBox.SelectedIndex = 0;
        }
    }

    private void SaveButton_Click(object sender, RoutedEventArgs e)
    {
        if (_viewModel.Settings?.Modem != null)
        {
            if (int.TryParse(BaudRateTextBox.Text, out int baudRate))
                _viewModel.Settings.Modem.BaudRate = baudRate;
            if (int.TryParse(ReadTimeoutTextBox.Text, out int readTimeout))
                _viewModel.Settings.Modem.ReadTimeout = readTimeout;
            if (int.TryParse(MaxModemsTextBox.Text, out int maxModems))
                _viewModel.Settings.Modem.MaxModems = maxModems;
        }

        _viewModel.OrangeCashPassword = OrangeCashPasswordTextBox.Text;
        _viewModel.VodafoneCashPassword = VodafoneCashPasswordTextBox.Text;
        _viewModel.EtisalatCashPassword = EtisalatCashPasswordTextBox.Text;
        _viewModel.AutoRenewValidityForAll = AutoRenewValidityCheckBox.IsChecked ?? false;
        
        var selectedItem = OperatorComboBox.SelectedItem as ComboBoxItem;
        _viewModel.SelectedOperator = selectedItem?.Tag?.ToString() ?? "All";

        _viewModel.SaveSettingsCommand.Execute(null);
        _viewModel.StatusMessage = "تم حفظ الإعدادات بنجاح";
        DialogResult = true;
        Close();
    }

    private void CancelButton_Click(object sender, RoutedEventArgs e)
    {
        DialogResult = false;
        Close();
    }

    private void CloseButton_Click(object sender, RoutedEventArgs e)
    {
        DialogResult = false;
        Close();
    }

    private void TitleBar_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
    {
        if (e.ClickCount == 1)
        {
            DragMove();
        }
    }
}
