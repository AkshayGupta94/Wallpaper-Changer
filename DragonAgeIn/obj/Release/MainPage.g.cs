﻿#pragma checksum "C:\Users\Akshay\documents\visual studio 2013\Projects\DragonAgeIn\DragonAgeIn\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "90C4770CB069F6FF6300A4BBDC47AE15"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Microsoft.Phone.Controls;
using System;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Resources;
using System.Windows.Shapes;
using System.Windows.Threading;


namespace DragonAgeIn {
    
    
    public partial class MainPage : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.StackPanel TitlePanel;
        
        internal System.Windows.Controls.TextBlock Top;
        
        internal System.Windows.Controls.TextBlock Bottom;
        
        internal System.Windows.Controls.Grid ContentPanel;
        
        internal System.Windows.Controls.Button MyButton;
        
        internal System.Windows.Controls.Image MainImage;
        
        internal System.Windows.Controls.ScrollViewer MyScroll;
        
        internal System.Windows.Controls.Grid MyGrid;
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Windows.Application.LoadComponent(this, new System.Uri("/DragonAgeIn;component/MainPage.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.TitlePanel = ((System.Windows.Controls.StackPanel)(this.FindName("TitlePanel")));
            this.Top = ((System.Windows.Controls.TextBlock)(this.FindName("Top")));
            this.Bottom = ((System.Windows.Controls.TextBlock)(this.FindName("Bottom")));
            this.ContentPanel = ((System.Windows.Controls.Grid)(this.FindName("ContentPanel")));
            this.MyButton = ((System.Windows.Controls.Button)(this.FindName("MyButton")));
            this.MainImage = ((System.Windows.Controls.Image)(this.FindName("MainImage")));
            this.MyScroll = ((System.Windows.Controls.ScrollViewer)(this.FindName("MyScroll")));
            this.MyGrid = ((System.Windows.Controls.Grid)(this.FindName("MyGrid")));
        }
    }
}

