// Updated by XamlIntelliSenseFileGenerator 10/6/2021 10:26:44 AM
#pragma checksum "..\..\..\MainWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8A8696698BB0B5A17C2589E63B876C5295F00D78"
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


namespace WpfTutorialSamples.Audio_and_Video
{


    /// <summary>
    /// MediaPlayerVideoControlSample
    /// </summary>
    public partial class MediaPlayerVideoControlSample : System.Windows.Window, System.Windows.Markup.IComponentConnector
    {

#line default
#line hidden

        private bool _contentLoaded;

        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.0.0")]
        public void InitializeComponent()
        {
            if (_contentLoaded)
            {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/video playing on wpf;V1.0.0.0;component/mainwindow.xaml", System.UriKind.Relative);

#line 1 "..\..\..\MainWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);

#line default
#line hidden
        }

        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
        {
            switch (connectionId)
            {
                case 1:
                    this.mePlayer = ((System.Windows.Controls.MediaElement)(target));
                    return;
                case 2:
                    this.lblStatus = ((System.Windows.Controls.Label)(target));
                    return;
                case 3:
                    this.btnPlay = ((System.Windows.Controls.Button)(target));

#line 17 "..\..\..\MainWindow.xaml"
                    this.btnPlay.Click += new System.Windows.RoutedEventHandler(this.btnPlay_Click);

#line default
#line hidden
                    return;
                case 4:
                    this.btnPause = ((System.Windows.Controls.Button)(target));

#line 18 "..\..\..\MainWindow.xaml"
                    this.btnPause.Click += new System.Windows.RoutedEventHandler(this.btnPause_Click);

#line default
#line hidden
                    return;
                case 5:
                    this.btnStop = ((System.Windows.Controls.Button)(target));

#line 19 "..\..\..\MainWindow.xaml"
                    this.btnStop.Click += new System.Windows.RoutedEventHandler(this.btnStop_Click);

#line default
#line hidden
                    return;
            }
            this._contentLoaded = true;
        }
    }
}

