#pragma checksum "..\..\..\LoginPage.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2BA896E6B2AC3A5CB191E707BFE1228276A77F31"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;
using WPF_Chat;


namespace WPF_Chat {
    
    
    /// <summary>
    /// LoginPage
    /// </summary>
    public partial class LoginPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 14 "..\..\..\LoginPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button LoginCloseButton;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\LoginPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button LoginMaximizeButton;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\..\LoginPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button LoginMinimizeButton;
        
        #line default
        #line hidden
        
        
        #line 57 "..\..\..\LoginPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button LoginField;
        
        #line default
        #line hidden
        
        
        #line 64 "..\..\..\LoginPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button PasswordField;
        
        #line default
        #line hidden
        
        
        #line 70 "..\..\..\LoginPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button LoginButton;
        
        #line default
        #line hidden
        
        
        #line 80 "..\..\..\LoginPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button RegisterButton;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.9.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/WPF_Chat;component/loginpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\LoginPage.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.9.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 11 "..\..\..\LoginPage.xaml"
            ((System.Windows.Controls.StackPanel)(target)).MouseMove += new System.Windows.Input.MouseEventHandler(this.UIElement_OnMouseMove);
            
            #line default
            #line hidden
            return;
            case 2:
            this.LoginCloseButton = ((System.Windows.Controls.Button)(target));
            
            #line 25 "..\..\..\LoginPage.xaml"
            this.LoginCloseButton.Click += new System.Windows.RoutedEventHandler(this.LoginCloseButton_OnClick);
            
            #line default
            #line hidden
            return;
            case 3:
            this.LoginMaximizeButton = ((System.Windows.Controls.Button)(target));
            
            #line 38 "..\..\..\LoginPage.xaml"
            this.LoginMaximizeButton.Click += new System.Windows.RoutedEventHandler(this.LoginMaximizeButton_OnClick);
            
            #line default
            #line hidden
            return;
            case 4:
            this.LoginMinimizeButton = ((System.Windows.Controls.Button)(target));
            
            #line 51 "..\..\..\LoginPage.xaml"
            this.LoginMinimizeButton.Click += new System.Windows.RoutedEventHandler(this.LoginMinimizeButton_OnClick);
            
            #line default
            #line hidden
            return;
            case 5:
            this.LoginField = ((System.Windows.Controls.Button)(target));
            
            #line 61 "..\..\..\LoginPage.xaml"
            this.LoginField.MouseLeave += new System.Windows.Input.MouseEventHandler(this.LoginField_OnMouseLeave);
            
            #line default
            #line hidden
            
            #line 62 "..\..\..\LoginPage.xaml"
            this.LoginField.MouseEnter += new System.Windows.Input.MouseEventHandler(this.LoginField_OnMouseEnter);
            
            #line default
            #line hidden
            return;
            case 6:
            this.PasswordField = ((System.Windows.Controls.Button)(target));
            
            #line 68 "..\..\..\LoginPage.xaml"
            this.PasswordField.Click += new System.Windows.RoutedEventHandler(this.PasswordField_OnClick);
            
            #line default
            #line hidden
            return;
            case 7:
            this.LoginButton = ((System.Windows.Controls.Button)(target));
            
            #line 75 "..\..\..\LoginPage.xaml"
            this.LoginButton.Click += new System.Windows.RoutedEventHandler(this.LoginButton_OnClick);
            
            #line default
            #line hidden
            
            #line 75 "..\..\..\LoginPage.xaml"
            this.LoginButton.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.LoginButton_MouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            case 8:
            this.RegisterButton = ((System.Windows.Controls.Button)(target));
            
            #line 85 "..\..\..\LoginPage.xaml"
            this.RegisterButton.Click += new System.Windows.RoutedEventHandler(this.RegisterButton_OnClick);
            
            #line default
            #line hidden
            
            #line 87 "..\..\..\LoginPage.xaml"
            this.RegisterButton.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.RegisterButton_MouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

