﻿#pragma checksum "..\..\..\..\View\GatherStorage.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1AD22725C537806735A8A55A821D4C8D377C10F7"
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
    /// GatherStorage
    /// </summary>
    public partial class GatherStorage : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 11 "..\..\..\..\View\GatherStorage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox comboBoxChoice;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\..\..\View\GatherStorage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label labelHeading;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\..\..\View\GatherStorage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button buttonGather;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\..\..\View\GatherStorage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textBoxNumber;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\..\View\GatherStorage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button buttonDown;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\..\..\View\GatherStorage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button buttonUp;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\..\View\GatherStorage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label labelChoice;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\..\View\GatherStorage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label labelNumberStorage;
        
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
            System.Uri resourceLocater = new System.Uri("/FactoryStorage;component/view/gatherstorage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\View\GatherStorage.xaml"
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
            
            #line 9 "..\..\..\..\View\GatherStorage.xaml"
            ((FactoryStorage.View.GatherStorage)(target)).Closing += new System.ComponentModel.CancelEventHandler(this.GatherStorage_Closing);
            
            #line default
            #line hidden
            return;
            case 2:
            this.comboBoxChoice = ((System.Windows.Controls.ComboBox)(target));
            
            #line 11 "..\..\..\..\View\GatherStorage.xaml"
            this.comboBoxChoice.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.comboBoxChoice_CelectionChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.labelHeading = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            this.buttonGather = ((System.Windows.Controls.Button)(target));
            
            #line 13 "..\..\..\..\View\GatherStorage.xaml"
            this.buttonGather.Click += new System.Windows.RoutedEventHandler(this.buttonGather_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.textBoxNumber = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.buttonDown = ((System.Windows.Controls.Button)(target));
            
            #line 16 "..\..\..\..\View\GatherStorage.xaml"
            this.buttonDown.Click += new System.Windows.RoutedEventHandler(this.buttonDown_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.buttonUp = ((System.Windows.Controls.Button)(target));
            
            #line 17 "..\..\..\..\View\GatherStorage.xaml"
            this.buttonUp.Click += new System.Windows.RoutedEventHandler(this.buttonUp_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.labelChoice = ((System.Windows.Controls.Label)(target));
            return;
            case 9:
            this.labelNumberStorage = ((System.Windows.Controls.Label)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

