using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Navigation;


namespace WPF_Chat;

public partial class LoginPage : Page
{
    private WindowState WindowState;

    public LoginPage() => InitializeComponent();

    private void LoginCloseButton_OnClick(object sender, RoutedEventArgs e)
    {
        Application.Current.Shutdown();
        this.Cursor = Cursors.Hand;
    }

    private void LoginMaximizeButton_OnClick(object sender, RoutedEventArgs e)
    {
        this.WindowState = WindowState.Maximized;
        this.Cursor = Cursors.Hand;
    }


    private void LoginMinimizeButton_OnClick(object sender, RoutedEventArgs e)
    {
        this.WindowState = WindowState.Minimized;
        this.Cursor = Cursors.Hand;
    }

    private void LoginField_OnMouseLeave(object sender, MouseEventArgs e)
    {
        Application.Current.Shutdown();
        this.Cursor = Cursors.Hand;
    }

    private void UIElement_OnMouseMove(object sender, MouseEventArgs e)
    {
        this.Cursor = Cursors.No;
    }

    private void LoginField_OnMouseEnter(object sender, MouseEventArgs e)
    {
        Application.Current.Shutdown();
        this.Cursor = Cursors.Hand;
    }

    private void LoginButton_OnClick(object sender, RoutedEventArgs e, MainWindow? mainWindow)
    {
        mainWindow.Visibility = Visibility.Visible;
       Window win = (Window)this.Parent;
       win.Close();
    }

    public object MainWindow { get; set; }

    private void RegisterButton_OnClick(object sender, RoutedEventArgs e)
    {
        NavigationWindow register = new NavigationWindow();
        register.Source = new Uri("RegistrationPage", UriKind.Relative);
        register.Show();
        this.Visibility = Visibility.Visible;
    }

    private void PasswordField_OnClick(object sender, RoutedEventArgs e)
    {
        
    }
    private void Border_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
    {
        if (e.LeftButton == MouseButtonState.Pressed)
        {
            DragMove(); 
        }
    }

    private void DragMove()
    {
        throw new System.NotImplementedException();
    }

    private void LoginButton_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
    {
        MainWindow mainWindow = new MainWindow();
        this.Content = mainWindow;
    }

    private void RegisterButton_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
    {
        RegistrationPage page = new RegistrationPage();
        this.Content = page;
    }

    private void LoginButton_OnClick(object sender, RoutedEventArgs e)
    {
        NavigationWindow login = new NavigationWindow();
        login.Source = new Uri("MainWindow", UriKind.Relative);
        login.Show();
        this.Visibility = Visibility.Visible;
    }
}