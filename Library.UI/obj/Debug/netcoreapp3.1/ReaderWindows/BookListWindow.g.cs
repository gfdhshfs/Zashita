﻿#pragma checksum "..\..\..\..\ReaderWindows\BookListWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "B3B83146CFE16FCD7FD6626D1247D54F8D3E3688"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using Library.UI.ReaderWindows;
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


namespace Library.UI.ReaderWindows {
    
    
    /// <summary>
    /// BookListWindow
    /// </summary>
    public partial class BookListWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        /// <summary>
        /// BookGrid Name Field
        /// </summary>
        
        #line 15 "..\..\..\..\ReaderWindows\BookListWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        public System.Windows.Controls.DataGrid BookGrid;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\..\..\ReaderWindows\BookListWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox DataFiltrationTextBox;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\..\ReaderWindows\BookListWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox FiltrationColumnListBox;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\..\..\ReaderWindows\BookListWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button SignOutButton;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.15.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Library.UI;component/readerwindows/booklistwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\ReaderWindows\BookListWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.15.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.BookGrid = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 2:
            this.DataFiltrationTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.FiltrationColumnListBox = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 4:
            this.SignOutButton = ((System.Windows.Controls.Button)(target));
            
            #line 45 "..\..\..\..\ReaderWindows\BookListWindow.xaml"
            this.SignOutButton.Click += new System.Windows.RoutedEventHandler(this.SignOutButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
