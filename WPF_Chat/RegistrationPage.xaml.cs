using System.Windows;
using System.Windows.Input;

namespace WPF_Chat;

public partial class RegistrationPage : Window
{
    public RegistrationPage()
    {
        InitializeComponent();
    }

    private void Border_MouseDown(object sender, MouseButtonEventArgs e)
    {
        if (e.LeftButton == MouseButtonState.Pressed)
        {
            DragMove(); 
        }
    }

    private void RegisterCloseButton_OnClick(object sender, RoutedEventArgs e)
    {
        Application.Current.Shutdown();
    }

    private void RegisterMinimizeButton_OnClick(object sender, RoutedEventArgs e)
    {
        this.WindowState = WindowState.Minimized;
    }
}