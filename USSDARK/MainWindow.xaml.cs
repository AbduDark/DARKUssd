using System.Windows;
using System.Windows.Controls;
using USSDARK.ViewModels;

namespace USSDARK;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        DataContext = new MainViewModel();
        Closing += MainWindow_Closing;
    }

    private void MainWindow_Closing(object? sender, System.ComponentModel.CancelEventArgs e)
    {
        if (DataContext is MainViewModel vm)
        {
            vm.Dispose();
        }
    }

    private void CloseButton_Click(object sender, RoutedEventArgs e)
    {
        if (DataContext is MainViewModel vm)
        {
            vm.Dispose();
        }
        Application.Current.Shutdown();
    }

    private void SettingsButton_Click(object sender, RoutedEventArgs e)
    {
        MessageBox.Show("Settings not implemented in this version", "USSDARK");
    }

    private void CopyOtpButton_Click(object sender, RoutedEventArgs e)
    {
        MessageBox.Show("OTP feature not implemented in this version", "USSDARK");
    }
}
