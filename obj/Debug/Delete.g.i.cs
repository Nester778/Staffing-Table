﻿#pragma checksum "..\..\Delete.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "24DF1476ACA978E6595DFAABFF8A4C607AE6756E4B3C681B942B63BEF572BE14"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using Kursova;
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


namespace Kursova {
    
    
    /// <summary>
    /// Delete
    /// </summary>
    public partial class Delete : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 13 "..\..\Delete.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button page1;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\Delete.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button page2;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\Delete.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button page3;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\Delete.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button menu;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\Delete.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox DelBox;
        
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
            System.Uri resourceLocater = new System.Uri("/Kursova;component/delete.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Delete.xaml"
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
            
            #line 9 "..\..\Delete.xaml"
            ((Kursova.Delete)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.page1 = ((System.Windows.Controls.Button)(target));
            
            #line 13 "..\..\Delete.xaml"
            this.page1.Click += new System.Windows.RoutedEventHandler(this.Page1_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.page2 = ((System.Windows.Controls.Button)(target));
            
            #line 14 "..\..\Delete.xaml"
            this.page2.Click += new System.Windows.RoutedEventHandler(this.Page2_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.page3 = ((System.Windows.Controls.Button)(target));
            
            #line 15 "..\..\Delete.xaml"
            this.page3.Click += new System.Windows.RoutedEventHandler(this.Page3_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.menu = ((System.Windows.Controls.Button)(target));
            
            #line 16 "..\..\Delete.xaml"
            this.menu.Click += new System.Windows.RoutedEventHandler(this.Menu_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 20 "..\..\Delete.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Insert_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 21 "..\..\Delete.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Updata_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            
            #line 22 "..\..\Delete.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.delete_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.DelBox = ((System.Windows.Controls.ComboBox)(target));
            
            #line 23 "..\..\Delete.xaml"
            this.DelBox.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.DelBox_SelectionChanged);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
