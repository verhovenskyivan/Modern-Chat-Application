using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

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
        
    }

    private void UIElement_OnMouseMove(object sender, MouseEventArgs e)
    {
      
    }

    private void LoginField_OnMouseEnter(object sender, MouseEventArgs e)
    {
       
    }

    private void LoginButton_OnClick(object sender, RoutedEventArgs e)
    {
    
        this.Content = MainWindow;
    }

    public object MainWindow { get; set; }

    private void RegisterButton_OnClick(object sender, RoutedEventArgs e)
    {
        
    }
}