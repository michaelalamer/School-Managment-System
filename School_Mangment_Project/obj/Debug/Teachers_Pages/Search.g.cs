﻿#pragma checksum "..\..\..\Teachers_Pages\Search.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "642C19C09C0476D26416E17F406DBE11E903AB2D"
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
    /// Search
    /// </summary>
    public partial class Search : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 24 "..\..\..\Teachers_Pages\Search.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Search_Button;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\Teachers_Pages\Search.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox Grade;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\Teachers_Pages\Search.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Quiz_Grade;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\Teachers_Pages\Search.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Save_Button;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\..\Teachers_Pages\Search.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Edit_Button;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\..\Teachers_Pages\Search.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker Attedance_Date;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\..\Teachers_Pages\Search.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton Check;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\..\Teachers_Pages\Search.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton Check1;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\..\Teachers_Pages\Search.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Save_Attendance_Button;
        
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
            System.Uri resourceLocater = new System.Uri("/School_Mangment_Project;component/teachers_pages/search.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Teachers_Pages\Search.xaml"
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
            this.Search_Button = ((System.Windows.Controls.Button)(target));
            return;
            case 2:
            this.Grade = ((System.Windows.Controls.ComboBox)(target));
            
            #line 29 "..\..\..\Teachers_Pages\Search.xaml"
            this.Grade.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.Quiz_Name_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.Quiz_Grade = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.Save_Button = ((System.Windows.Controls.Button)(target));
            
            #line 32 "..\..\..\Teachers_Pages\Search.xaml"
            this.Save_Button.Click += new System.Windows.RoutedEventHandler(this.Save_Button_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.Edit_Button = ((System.Windows.Controls.Button)(target));
            
            #line 35 "..\..\..\Teachers_Pages\Search.xaml"
            this.Edit_Button.Click += new System.Windows.RoutedEventHandler(this.Edit_Button_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.Attedance_Date = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 7:
            this.Check = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 8:
            this.Check1 = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 9:
            this.Save_Attendance_Button = ((System.Windows.Controls.Button)(target));
            
            #line 44 "..\..\..\Teachers_Pages\Search.xaml"
            this.Save_Attendance_Button.Click += new System.Windows.RoutedEventHandler(this.Save_Button_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

