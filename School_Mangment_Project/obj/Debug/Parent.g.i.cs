﻿#pragma checksum "..\..\Parent.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3EC34B8B10BA9A42D0FA57E505BBF55D90EB0AFC"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Transitions;
using School_Mangment_Project;
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


namespace School_Mangment_Project {
    
    
    /// <summary>
    /// Parent
    /// </summary>
    public partial class Parent : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 71 "..\..\Parent.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Media.Animation.BeginStoryboard CloseMenu_BeginStoryboard;
        
        #line default
        #line hidden
        
        
        #line 75 "..\..\Parent.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel StackPanelMenu;
        
        #line default
        #line hidden
        
        
        #line 88 "..\..\Parent.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button button;
        
        #line default
        #line hidden
        
        
        #line 106 "..\..\Parent.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListViewItem attendance;
        
        #line default
        #line hidden
        
        
        #line 120 "..\..\Parent.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListViewItem grade;
        
        #line default
        #line hidden
        
        
        #line 134 "..\..\Parent.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListViewItem logout;
        
        #line default
        #line hidden
        
        
        #line 150 "..\..\Parent.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid GridMain;
        
        #line default
        #line hidden
        
        
        #line 195 "..\..\Parent.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Frame Main_Content;
        
        #line default
        #line hidden
        
        
        #line 202 "..\..\Parent.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonCloseMenu;
        
        #line default
        #line hidden
        
        
        #line 205 "..\..\Parent.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonOpenMenu;
        
        #line default
        #line hidden
        
        
        #line 214 "..\..\Parent.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonClose;
        
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
            System.Uri resourceLocater = new System.Uri("/School_Mangment_Project;component/parent.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Parent.xaml"
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
            this.CloseMenu_BeginStoryboard = ((System.Windows.Media.Animation.BeginStoryboard)(target));
            return;
            case 2:
            this.StackPanelMenu = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 3:
            this.button = ((System.Windows.Controls.Button)(target));
            
            #line 88 "..\..\Parent.xaml"
            this.button.Click += new System.Windows.RoutedEventHandler(this.button_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.attendance = ((System.Windows.Controls.ListViewItem)(target));
            
            #line 106 "..\..\Parent.xaml"
            this.attendance.Selected += new System.Windows.RoutedEventHandler(this.attendance_Selected);
            
            #line default
            #line hidden
            return;
            case 5:
            this.grade = ((System.Windows.Controls.ListViewItem)(target));
            
            #line 120 "..\..\Parent.xaml"
            this.grade.Selected += new System.Windows.RoutedEventHandler(this.grade_Selected);
            
            #line default
            #line hidden
            return;
            case 6:
            this.logout = ((System.Windows.Controls.ListViewItem)(target));
            
            #line 134 "..\..\Parent.xaml"
            this.logout.Selected += new System.Windows.RoutedEventHandler(this.logout_Selected);
            
            #line default
            #line hidden
            return;
            case 7:
            this.GridMain = ((System.Windows.Controls.Grid)(target));
            return;
            case 8:
            this.Main_Content = ((System.Windows.Controls.Frame)(target));
            return;
            case 9:
            this.ButtonCloseMenu = ((System.Windows.Controls.Button)(target));
            
            #line 202 "..\..\Parent.xaml"
            this.ButtonCloseMenu.Click += new System.Windows.RoutedEventHandler(this.ButtonCloseMenu_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.ButtonOpenMenu = ((System.Windows.Controls.Button)(target));
            
            #line 205 "..\..\Parent.xaml"
            this.ButtonOpenMenu.Click += new System.Windows.RoutedEventHandler(this.ButtonOpenMenu_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            this.ButtonClose = ((System.Windows.Controls.Button)(target));
            
            #line 214 "..\..\Parent.xaml"
            this.ButtonClose.Click += new System.Windows.RoutedEventHandler(this.ButtonClose_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

