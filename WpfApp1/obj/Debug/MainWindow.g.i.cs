﻿#pragma checksum "..\..\MainWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "74FE28259A142277ABB5B387C84BC0F3A4EB59BDD117BF8A17D0D90D6362D468"
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
using System.Windows.Shell;
using WpfApp1;


namespace WpfApp1 {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 74 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox chairsList;
        
        #line default
        #line hidden
        
        
        #line 106 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel stackPanel;
        
        #line default
        #line hidden
        
        
        #line 148 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image last_item;
        
        #line default
        #line hidden
        
        
        #line 149 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock last_item_label;
        
        #line default
        #line hidden
        
        /// <summary>
        /// last_bought Name Field
        /// </summary>
        
        #line 152 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        public System.Windows.Controls.Image last_bought;
        
        #line default
        #line hidden
        
        /// <summary>
        /// last_bought_label Name Field
        /// </summary>
        
        #line 153 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        public System.Windows.Controls.TextBlock last_bought_label;
        
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
            System.Uri resourceLocater = new System.Uri("/WpfApp1;component/mainwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\MainWindow.xaml"
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
            this.chairsList = ((System.Windows.Controls.ListBox)(target));
            
            #line 75 "..\..\MainWindow.xaml"
            this.chairsList.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.chairsList_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 96 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.CheckBox)(target)).Checked += new System.Windows.RoutedEventHandler(this.CheckBox_Checked);
            
            #line default
            #line hidden
            
            #line 96 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.CheckBox)(target)).Unchecked += new System.Windows.RoutedEventHandler(this.CheckBox_Unchecked);
            
            #line default
            #line hidden
            return;
            case 3:
            this.stackPanel = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 4:
            
            #line 115 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.RadioButton)(target)).Checked += new System.Windows.RoutedEventHandler(this.RadioButton_Checked);
            
            #line default
            #line hidden
            
            #line 115 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.RadioButton)(target)).Unchecked += new System.Windows.RoutedEventHandler(this.RadioButton_Unchecked);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 116 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.RadioButton)(target)).Checked += new System.Windows.RoutedEventHandler(this.RadioButton_Checked_1);
            
            #line default
            #line hidden
            
            #line 116 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.RadioButton)(target)).Unchecked += new System.Windows.RoutedEventHandler(this.RadioButton_Unchecked_1);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 122 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 125 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.TreeViewItem)(target)).Selected += new System.Windows.RoutedEventHandler(this.TreeViewItem_Selected_1);
            
            #line default
            #line hidden
            return;
            case 8:
            
            #line 126 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.TreeViewItem)(target)).Selected += new System.Windows.RoutedEventHandler(this.TreeViewItem_Selected_1);
            
            #line default
            #line hidden
            return;
            case 9:
            
            #line 132 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.TreeViewItem)(target)).Selected += new System.Windows.RoutedEventHandler(this.TreeViewItem_Selected);
            
            #line default
            #line hidden
            return;
            case 10:
            
            #line 133 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.TreeViewItem)(target)).Selected += new System.Windows.RoutedEventHandler(this.TreeViewItem_Selected);
            
            #line default
            #line hidden
            return;
            case 11:
            
            #line 134 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.TreeViewItem)(target)).Selected += new System.Windows.RoutedEventHandler(this.TreeViewItem_Selected);
            
            #line default
            #line hidden
            return;
            case 12:
            
            #line 135 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.TreeViewItem)(target)).Selected += new System.Windows.RoutedEventHandler(this.TreeViewItem_Selected);
            
            #line default
            #line hidden
            return;
            case 13:
            
            #line 136 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.TreeViewItem)(target)).Selected += new System.Windows.RoutedEventHandler(this.TreeViewItem_Selected);
            
            #line default
            #line hidden
            return;
            case 14:
            
            #line 137 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.TreeViewItem)(target)).Selected += new System.Windows.RoutedEventHandler(this.TreeViewItem_Selected);
            
            #line default
            #line hidden
            return;
            case 15:
            
            #line 138 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.TreeViewItem)(target)).Selected += new System.Windows.RoutedEventHandler(this.TreeViewItem_Selected);
            
            #line default
            #line hidden
            return;
            case 16:
            
            #line 139 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.TreeViewItem)(target)).Selected += new System.Windows.RoutedEventHandler(this.TreeViewItem_Selected);
            
            #line default
            #line hidden
            return;
            case 17:
            
            #line 142 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.TextBox)(target)).TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TextBox_TextChanged);
            
            #line default
            #line hidden
            return;
            case 18:
            
            #line 145 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.TextBox)(target)).TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TextBox_TextChanged_1);
            
            #line default
            #line hidden
            return;
            case 19:
            this.last_item = ((System.Windows.Controls.Image)(target));
            return;
            case 20:
            this.last_item_label = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 21:
            this.last_bought = ((System.Windows.Controls.Image)(target));
            return;
            case 22:
            this.last_bought_label = ((System.Windows.Controls.TextBlock)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

