﻿#pragma checksum "..\..\..\UserControls\UserControlCrreateAddUser.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "BA794A37D083827E6C1E18D3D0BD6C86A225F5DE4AD6337DBB05B3B274EC0F2E"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using GoldDigger;
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


namespace GoldDigger {
    
    
    /// <summary>
    /// UserControlCrreateAddUser
    /// </summary>
    public partial class UserControlCrreateAddUser : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 11 "..\..\..\UserControls\UserControlCrreateAddUser.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid GridUserMain;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\..\UserControls\UserControlCrreateAddUser.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button buttonUCCUANewCustomer;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\..\UserControls\UserControlCrreateAddUser.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button buttonUCCAUCancelNewCustomer;
        
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
            System.Uri resourceLocater = new System.Uri("/GoldDigger;component/usercontrols/usercontrolcrreateadduser.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\UserControls\UserControlCrreateAddUser.xaml"
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
            this.GridUserMain = ((System.Windows.Controls.Grid)(target));
            return;
            case 2:
            this.buttonUCCUANewCustomer = ((System.Windows.Controls.Button)(target));
            
            #line 52 "..\..\..\UserControls\UserControlCrreateAddUser.xaml"
            this.buttonUCCUANewCustomer.Click += new System.Windows.RoutedEventHandler(this.buttonUCCUANewCustomer_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.buttonUCCAUCancelNewCustomer = ((System.Windows.Controls.Button)(target));
            
            #line 63 "..\..\..\UserControls\UserControlCrreateAddUser.xaml"
            this.buttonUCCAUCancelNewCustomer.Click += new System.Windows.RoutedEventHandler(this.buttonUCCAUCancelNewCustomer_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

