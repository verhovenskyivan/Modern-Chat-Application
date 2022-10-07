using System;
using System.Windows;
using System.Windows.Input;
using System.Windows.Navigation;

namespace WPF_Chat;

public partial class RegistrationPage : Window
{
    public RegistrationPage()
    {
        InitializeComponent();
    }

    private void Border_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
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

    private void RegisterMaximizeButton_OnClick(object sender, RoutedEventArgs e)
    {
        this.WindowState = WindowState.Maximized;
    }

    private void LoginButton_MouseLeftButtonDown(object sender, MouseButtonEventArgs e, object loginPage)
    {
      RegistrationPage page = new RegistrationPage();
        this.Content = loginPage;
    }

    private void LoginButton_Click(object sender, RoutedEventArgs e, object mainWindow)
    {
        NavigationWindow login = new NavigationWindow();
        login.Source = new Uri("MainWindow", UriKind.Relative);
        login.Show();
        this.Visibility = Visibility.Visible;
    }

    private void LoginButton_Click(object sender, RoutedEventArgs e)
    {
        NavigationWindow register = new NavigationWindow();
        register.Source = new Uri("MainWindow", UriKind.Relative);
        register.Show();
        this.Visibility = Visibility.Visible;
    }
}