﻿

#pragma checksum "C:\BookCode\Chapter03\StreetFoo.Client\StreetFoo.Client.UI\Copy of RegisterPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "FEADD44E3137AAC6F17FD9B66C61592C"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using Windows.Foundation;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Markup;

namespace StreetFoo.Client.UI
{
    public partial class RegisterPage : StreetFoo.Client.UI.Common.LayoutAwarePage
    {
        private StreetFoo.Client.UI.Common.LayoutAwarePage pageRoot;
        private Windows.UI.Xaml.Controls.Button backButton;
        private Windows.UI.Xaml.Controls.TextBlock pageTitle;
        private Windows.UI.Xaml.VisualState FullScreenLandscape;
        private Windows.UI.Xaml.VisualState Filled;
        private Windows.UI.Xaml.VisualState FullScreenPortrait;
        private Windows.UI.Xaml.VisualState Snapped;
        private bool _contentLoaded;

        [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent()
        {
            if (_contentLoaded)
                return;

            _contentLoaded = true;
            Application.LoadComponent(this, new System.Uri("ms-appx:///Copy of RegisterPage.xaml"), Windows.UI.Xaml.Controls.Primitives.ComponentResourceLocation.Application);
 
            pageRoot = (StreetFoo.Client.UI.Common.LayoutAwarePage)this.FindName("pageRoot");
            backButton = (Windows.UI.Xaml.Controls.Button)this.FindName("backButton");
            pageTitle = (Windows.UI.Xaml.Controls.TextBlock)this.FindName("pageTitle");
            FullScreenLandscape = (Windows.UI.Xaml.VisualState)this.FindName("FullScreenLandscape");
            Filled = (Windows.UI.Xaml.VisualState)this.FindName("Filled");
            FullScreenPortrait = (Windows.UI.Xaml.VisualState)this.FindName("FullScreenPortrait");
            Snapped = (Windows.UI.Xaml.VisualState)this.FindName("Snapped");
        }
    }
}



