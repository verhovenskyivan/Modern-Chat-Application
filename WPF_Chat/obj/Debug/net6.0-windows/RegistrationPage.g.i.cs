#pragma checksum "..\..\..\RegistrationPage.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "451ED51B9F4665A79F085DCB1CBD3ACAAE382986"
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
    /// RegistrationPage
    /// </summary>
    public partial class RegistrationPage : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 24 "..\..\..\RegistrationPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button RegisterCloseButton;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\..\RegistrationPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button RegisterMaximizeButton;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\..\RegistrationPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button RegisterMinimizeButton;
        
        #line default
        #line hidden
        
        
        #line 70 "..\..\..\RegistrationPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button LoginField;
        
        #line default
        #line hidden
        
        
        #line 75 "..\..\..\RegistrationPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button PasswordField;
        
        #line default
        #line hidden
        
        
        #line 81 "..\..\..\RegistrationPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button LoginButton;
        
        #line default
        #line hidden
        
        
        #line 87 "..\..\..\RegistrationPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button HelpButton;
        
        #line default
        #line hidden
        
        
        #line 93 "..\..\..\RegistrationPage.xaml"
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
            System.Uri resourceLocater = new System.Uri("/WPF_Chat;V1.0.0.0;component/registrationpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\RegistrationPage.xaml"
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
            this.RegisterCloseButton = ((System.Windows.Controls.Button)(target));
            
            #line 35 "..\..\..\RegistrationPage.xaml"
            this.RegisterCloseButton.Click += new System.Windows.RoutedEventHandler(this.RegisterCloseButton_OnClick);
            
            #line default
            #line hidden
            return;
            case 2:
            this.RegisterMaximizeButton = ((System.Windows.Controls.Button)(target));
            
            #line 48 "..\..\..\RegistrationPage.xaml"
            this.RegisterMaximizeButton.Click += new System.Windows.RoutedEventHandler(this.RegisterMaximizeButton_OnClick);
            
            #line default
            #line hidden
            return;
            case 3:
            this.RegisterMinimizeButton = ((System.Windows.Controls.Button)(target));
            
            #line 61 "..\..\..\RegistrationPage.xaml"
            this.RegisterMinimizeButton.Click += new System.Windows.RoutedEventHandler(this.RegisterMinimizeButton_OnClick);
            
            #line default
            #line hidden
            return;
            case 4:
            this.LoginField = ((System.Windows.Controls.Button)(target));
            return;
            case 5:
            this.PasswordField = ((System.Windows.Controls.Button)(target));
            return;
            case 6:
            this.LoginButton = ((System.Windows.Controls.Button)(target));
            
            #line 85 "..\..\..\RegistrationPage.xaml"
            this.LoginButton.Click += new System.Windows.RoutedEventHandler(this.LoginButton_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.HelpButton = ((System.Windows.Controls.Button)(target));
            return;
            case 8:
            this.RegisterButton = ((System.Windows.Controls.Button)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

