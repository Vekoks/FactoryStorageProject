﻿#pragma checksum "..\..\..\..\View\CriticalNumber.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9A0A666D47E270F19A96F7AE98944711C3A08F29"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using FactoryStorage.View;
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


namespace FactoryStorage.View {
    
    
    /// <summary>
    /// CriticalNumber
    /// </summary>
    public partial class CriticalNumber : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 11 "..\..\..\..\View\CriticalNumber.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label labelheading;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\..\..\View\CriticalNumber.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textBoxMinNumber;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\..\..\View\CriticalNumber.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button buttonChange;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\..\..\View\CriticalNumber.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label labelMinNumber;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\..\..\View\CriticalNumber.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button buttonExit;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\..\View\CriticalNumber.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox listBoxCriticalElement;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.1.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/FactoryStorage;component/view/criticalnumber.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\View\CriticalNumber.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.1.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.labelheading = ((System.Windows.Controls.Label)(target));
            return;
            case 2:
            this.textBoxMinNumber = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.buttonChange = ((System.Windows.Controls.Button)(target));
            
            #line 13 "..\..\..\..\View\CriticalNumber.xaml"
            this.buttonChange.Click += new System.Windows.RoutedEventHandler(this.buttonChange_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.labelMinNumber = ((System.Windows.Controls.Label)(target));
            return;
            case 5:
            this.buttonExit = ((System.Windows.Controls.Button)(target));
            
            #line 15 "..\..\..\..\View\CriticalNumber.xaml"
            this.buttonExit.Click += new System.Windows.RoutedEventHandler(this.buttonExit_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.listBoxCriticalElement = ((System.Windows.Controls.ListBox)(target));
            
            #line 16 "..\..\..\..\View\CriticalNumber.xaml"
            this.listBoxCriticalElement.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.listBoxCriticalElement_SelectionChanged);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

