﻿#pragma checksum "..\..\..\Modals\Dashboard_Modal.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "80D065F4565CF19DBC3328731711F5A2D55F0A8F9EC758CE508C668D527D8DB3"
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
using LiveCharts.Wpf;
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
    /// Dashboard_Modal
    /// </summary>
    public partial class Dashboard_Modal : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 60 "..\..\..\Modals\Dashboard_Modal.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock tbemployeeCount;
        
        #line default
        #line hidden
        
        
        #line 120 "..\..\..\Modals\Dashboard_Modal.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock tbPresent;
        
        #line default
        #line hidden
        
        
        #line 156 "..\..\..\Modals\Dashboard_Modal.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock tbLate;
        
        #line default
        #line hidden
        
        
        #line 192 "..\..\..\Modals\Dashboard_Modal.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock tbAbsent;
        
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
            System.Uri resourceLocater = new System.Uri("/ClockiFyAMS;component/modals/dashboard_modal.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Modals\Dashboard_Modal.xaml"
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
            this.tbemployeeCount = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 2:
            this.tbPresent = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 3:
            this.tbLate = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 4:
            this.tbAbsent = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 5:
            
            #line 239 "..\..\..\Modals\Dashboard_Modal.xaml"
            ((LiveCharts.Wpf.PieChart)(target)).DataClick += new LiveCharts.Events.DataClickHandler(this.Chart_OnDataClick);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
