﻿#pragma checksum "..\..\..\..\gui\Pages\PScanner - Copy.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "E0BB36B382E76E28A6FFB9E4B1AD84D9"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using FirstFloor.ModernUI.Presentation;
using FirstFloor.ModernUI.Windows;
using FirstFloor.ModernUI.Windows.Controls;
using FirstFloor.ModernUI.Windows.Converters;
using FirstFloor.ModernUI.Windows.Navigation;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms.Integration;
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


namespace MCP.gui.Pages {
    
    
    /// <summary>
    /// PScanner
    /// </summary>
    public partial class PScanner : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 8 "..\..\..\..\gui\Pages\PScanner - Copy.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid _grid;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\..\gui\Pages\PScanner - Copy.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TabControl _tab;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\..\gui\Pages\PScanner - Copy.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MediaElement _media;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\..\..\gui\Pages\PScanner - Copy.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal FirstFloor.ModernUI.Windows.Controls.ModernButton BtnPlay;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\..\..\gui\Pages\PScanner - Copy.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal FirstFloor.ModernUI.Windows.Controls.ModernButton BtnPause;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\..\..\gui\Pages\PScanner - Copy.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal FirstFloor.ModernUI.Windows.Controls.ModernButton BtnStop;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\..\..\gui\Pages\PScanner - Copy.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnSaveMovies;
        
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
            System.Uri resourceLocater = new System.Uri("/MCP 2.0;component/gui/pages/pscanner%20-%20copy.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\gui\Pages\PScanner - Copy.xaml"
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
            this._grid = ((System.Windows.Controls.Grid)(target));
            return;
            case 2:
            this._tab = ((System.Windows.Controls.TabControl)(target));
            return;
            case 3:
            this._media = ((System.Windows.Controls.MediaElement)(target));
            return;
            case 4:
            this.BtnPlay = ((FirstFloor.ModernUI.Windows.Controls.ModernButton)(target));
            
            #line 41 "..\..\..\..\gui\Pages\PScanner - Copy.xaml"
            this.BtnPlay.Click += new System.Windows.RoutedEventHandler(this.BtnPlay_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.BtnPause = ((FirstFloor.ModernUI.Windows.Controls.ModernButton)(target));
            
            #line 42 "..\..\..\..\gui\Pages\PScanner - Copy.xaml"
            this.BtnPause.Click += new System.Windows.RoutedEventHandler(this.BtnPause_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.BtnStop = ((FirstFloor.ModernUI.Windows.Controls.ModernButton)(target));
            
            #line 43 "..\..\..\..\gui\Pages\PScanner - Copy.xaml"
            this.BtnStop.Click += new System.Windows.RoutedEventHandler(this.BtnStop_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.BtnSaveMovies = ((System.Windows.Controls.Button)(target));
            
            #line 47 "..\..\..\..\gui\Pages\PScanner - Copy.xaml"
            this.BtnSaveMovies.Click += new System.Windows.RoutedEventHandler(this.BtnSaveMovies_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

