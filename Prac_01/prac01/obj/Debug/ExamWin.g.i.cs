﻿#pragma checksum "..\..\ExamWin.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "718C475EF4E7A22D8316F28E9EE94C3482B5D3E63B606271F99E3C4906000464"
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
using prac01;


namespace prac01 {
    
    
    /// <summary>
    /// ExamWin
    /// </summary>
    public partial class ExamWin : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 24 "..\..\ExamWin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock CountSym;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\ExamWin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock CodeWord;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\ExamWin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock Attempts;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\ExamWin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock Dispers;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\ExamWin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock Pident;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\ExamWin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock FirstKindErr;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\ExamWin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock SecKindErr;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\ExamWin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox InputCode;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\ExamWin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button NextAttempt;
        
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
            System.Uri resourceLocater = new System.Uri("/prac01;component/examwin.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\ExamWin.xaml"
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
            this.CountSym = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 2:
            this.CodeWord = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 3:
            this.Attempts = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 4:
            this.Dispers = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 5:
            this.Pident = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 6:
            this.FirstKindErr = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 7:
            this.SecKindErr = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 8:
            
            #line 44 "..\..\ExamWin.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.InputCode = ((System.Windows.Controls.TextBox)(target));
            
            #line 45 "..\..\ExamWin.xaml"
            this.InputCode.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.ChangedInput);
            
            #line default
            #line hidden
            return;
            case 10:
            this.NextAttempt = ((System.Windows.Controls.Button)(target));
            
            #line 46 "..\..\ExamWin.xaml"
            this.NextAttempt.Click += new System.Windows.RoutedEventHandler(this.NextAttempt_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

