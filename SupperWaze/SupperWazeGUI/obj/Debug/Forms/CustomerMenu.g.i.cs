﻿#pragma checksum "..\..\..\Forms\CustomerMenu.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2B04154BC336E4D4E814D313A01126B0D0AE5BE5"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using SupperWazeGUI.Forms;
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


namespace SupperWazeGUI.Forms {
    
    
    /// <summary>
    /// CustomerMenu
    /// </summary>
    public partial class CustomerMenu : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 82 "..\..\..\Forms\CustomerMenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox nameNewClient;
        
        #line default
        #line hidden
        
        
        #line 88 "..\..\..\Forms\CustomerMenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox addressNewClient;
        
        #line default
        #line hidden
        
        
        #line 94 "..\..\..\Forms\CustomerMenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox telNewClient;
        
        #line default
        #line hidden
        
        
        #line 99 "..\..\..\Forms\CustomerMenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image saveNewCustomerBTN;
        
        #line default
        #line hidden
        
        
        #line 125 "..\..\..\Forms\CustomerMenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox telClient;
        
        #line default
        #line hidden
        
        
        #line 131 "..\..\..\Forms\CustomerMenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image okBTN;
        
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
            System.Uri resourceLocater = new System.Uri("/SupperWazeGUI;component/forms/customermenu.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Forms\CustomerMenu.xaml"
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
            this.nameNewClient = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.addressNewClient = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.telNewClient = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.saveNewCustomerBTN = ((System.Windows.Controls.Image)(target));
            
            #line 99 "..\..\..\Forms\CustomerMenu.xaml"
            this.saveNewCustomerBTN.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.saveNewCustomerBTN_MouseDown);
            
            #line default
            #line hidden
            return;
            case 5:
            this.telClient = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.okBTN = ((System.Windows.Controls.Image)(target));
            
            #line 131 "..\..\..\Forms\CustomerMenu.xaml"
            this.okBTN.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.okBTN_MouseDown);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
