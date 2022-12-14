﻿#pragma checksum "..\..\..\Modals\Administration.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "CE1E7F5531D69FE1D61F05A9D056B358CE80A697400A658D11DC171F020FFAA0"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using ClockiFyAMS.Modals;
using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Converters;
using MaterialDesignThemes.Wpf.Transitions;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
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


namespace ClockiFyAMS.Modals {
    
    
    /// <summary>
    /// Administration
    /// </summary>
    public partial class Administration : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 7 "..\..\..\Modals\Administration.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal ClockiFyAMS.Modals.Administration administrator;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\Modals\Administration.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock lbl_status;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\..\Modals\Administration.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_Close;
        
        #line default
        #line hidden
        
        
        #line 106 "..\..\..\Modals\Administration.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox username;
        
        #line default
        #line hidden
        
        
        #line 115 "..\..\..\Modals\Administration.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox curpw;
        
        #line default
        #line hidden
        
        
        #line 125 "..\..\..\Modals\Administration.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox npw;
        
        #line default
        #line hidden
        
        
        #line 135 "..\..\..\Modals\Administration.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox rnpw;
        
        #line default
        #line hidden
        
        
        #line 146 "..\..\..\Modals\Administration.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_Save;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/ClockiFyAMS;component/modals/administration.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Modals\Administration.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.administrator = ((ClockiFyAMS.Modals.Administration)(target));
            return;
            case 2:
            this.lbl_status = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 3:
            this.btn_Close = ((System.Windows.Controls.Button)(target));
            
            #line 45 "..\..\..\Modals\Administration.xaml"
            this.btn_Close.Click += new System.Windows.RoutedEventHandler(this.btn_Close_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.username = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.curpw = ((System.Windows.Controls.PasswordBox)(target));
            
            #line 114 "..\..\..\Modals\Administration.xaml"
            this.curpw.PasswordChanged += new System.Windows.RoutedEventHandler(this.pw_PasswordChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            this.npw = ((System.Windows.Controls.PasswordBox)(target));
            
            #line 124 "..\..\..\Modals\Administration.xaml"
            this.npw.PasswordChanged += new System.Windows.RoutedEventHandler(this.pw_PasswordChanged);
            
            #line default
            #line hidden
            return;
            case 7:
            this.rnpw = ((System.Windows.Controls.PasswordBox)(target));
            
            #line 134 "..\..\..\Modals\Administration.xaml"
            this.rnpw.PasswordChanged += new System.Windows.RoutedEventHandler(this.pw_PasswordChanged);
            
            #line default
            #line hidden
            return;
            case 8:
            this.btn_Save = ((System.Windows.Controls.Button)(target));
            
            #line 149 "..\..\..\Modals\Administration.xaml"
            this.btn_Save.Click += new System.Windows.RoutedEventHandler(this.btn_Save_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

