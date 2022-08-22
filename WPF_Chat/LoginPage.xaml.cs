using System.Windows;
using System.Windows.Controls;

namespace WPF_Chat;

public partial class LoginPage : Page
{
    private WindowState WindowState;

    public LoginPage()
    {
        InitializeComponent();
    }

    private void LoginCloseButton_OnClick(object sender, RoutedEventArgs e)
    {
        Application.Current.Shutdown();
    }

    private void LoginMaximizeButton_OnClick(object sender, RoutedEventArgs e)
    {
        this.WindowState = WindowState.Maximized;
    }


    private void LoginMinimizeButton_OnClick(object sender, RoutedEventArgs e)
    {
        this.WindowState = WindowState.Minimized;
    }
}