﻿#pragma checksum "..\..\..\MainViews\MenuView.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "C1EBA8D1469896BE7CA73C38B79F8CED568AEBD68055220E7AB4165D5F9EF1AF"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using ChestieMVP.MainViews;
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


namespace ChestieMVP.MainViews {
    
    
    /// <summary>
    /// MenuView
    /// </summary>
    public partial class MenuView : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 11 "..\..\..\MainViews\MenuView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem pack;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\..\MainViews\MenuView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem unpack;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\MainViews\MenuView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem ed;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\MainViews\MenuView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem help;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\MainViews\MenuView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem About;
        
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
            System.Uri resourceLocater = new System.Uri("/ChestieMVP;component/mainviews/menuview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\MainViews\MenuView.xaml"
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
            this.pack = ((System.Windows.Controls.MenuItem)(target));
            
            #line 11 "..\..\..\MainViews\MenuView.xaml"
            this.pack.Click += new System.Windows.RoutedEventHandler(this.Pack_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.unpack = ((System.Windows.Controls.MenuItem)(target));
            
            #line 12 "..\..\..\MainViews\MenuView.xaml"
            this.unpack.Click += new System.Windows.RoutedEventHandler(this.Unpack_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 13 "..\..\..\MainViews\MenuView.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.Compare_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 14 "..\..\..\MainViews\MenuView.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.Exit_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.ed = ((System.Windows.Controls.MenuItem)(target));
            return;
            case 6:
            
            #line 17 "..\..\..\MainViews\MenuView.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.Tree_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 18 "..\..\..\MainViews\MenuView.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.Full_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.help = ((System.Windows.Controls.MenuItem)(target));
            return;
            case 9:
            this.About = ((System.Windows.Controls.MenuItem)(target));
            
            #line 21 "..\..\..\MainViews\MenuView.xaml"
            this.About.Click += new System.Windows.RoutedEventHandler(this.About_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

