﻿#pragma checksum "..\..\..\Menu\Gameplay.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "D5A7A3C922CEBA199357B5AC3FEFEDF7DE6C7697"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

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


namespace WPFPageSwitch {
    
    
    /// <summary>
    /// Gameplay
    /// </summary>
    public partial class Gameplay : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 5 "..\..\..\Menu\Gameplay.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal WPFPageSwitch.Gameplay el;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\Menu\Gameplay.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid gameplayLayoutRoot;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\Menu\Gameplay.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Shapes.Ellipse elipsa;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\Menu\Gameplay.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox Comm_Port_Names;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\Menu\Gameplay.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Connect_btn;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\Menu\Gameplay.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Shapes.Ellipse start;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\..\Menu\Gameplay.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Shapes.Ellipse finish;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\..\Menu\Gameplay.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Shapes.Ellipse ball;
        
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
            System.Uri resourceLocater = new System.Uri("/JagoanFisika;component/menu/gameplay.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Menu\Gameplay.xaml"
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
            this.el = ((WPFPageSwitch.Gameplay)(target));
            return;
            case 2:
            this.gameplayLayoutRoot = ((System.Windows.Controls.Grid)(target));
            return;
            case 3:
            
            #line 30 "..\..\..\Menu\Gameplay.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.elipsa = ((System.Windows.Shapes.Ellipse)(target));
            return;
            case 5:
            this.Comm_Port_Names = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 6:
            this.Connect_btn = ((System.Windows.Controls.Button)(target));
            
            #line 33 "..\..\..\Menu\Gameplay.xaml"
            this.Connect_btn.Click += new System.Windows.RoutedEventHandler(this.Connect_Comms);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 34 "..\..\..\Menu\Gameplay.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Send_Data0);
            
            #line default
            #line hidden
            return;
            case 8:
            
            #line 35 "..\..\..\Menu\Gameplay.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Send_Data1);
            
            #line default
            #line hidden
            return;
            case 9:
            this.start = ((System.Windows.Shapes.Ellipse)(target));
            return;
            case 10:
            this.finish = ((System.Windows.Shapes.Ellipse)(target));
            return;
            case 11:
            this.ball = ((System.Windows.Shapes.Ellipse)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

