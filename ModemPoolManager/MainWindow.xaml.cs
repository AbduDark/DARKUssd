using System.Windows;
using ModemPoolManager.ViewModels;

namespace ModemPoolManager;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        DataContext = new MainViewModel();
    }
}
