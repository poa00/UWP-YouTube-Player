﻿#pragma checksum "D:\Project\Windows 10 Developement\Template\UWPYouTubePlayer\UWPYouTubePlayer\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "4CA9E30F1C149C759B44EDE81019A4F2"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace UWPYouTubePlayer
{
    partial class MainPage : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                {
                    global::Windows.UI.Xaml.Controls.Page element1 = (global::Windows.UI.Xaml.Controls.Page)(target);
                    #line 9 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Page)element1).Loaded += this.Page_LoadedAsync;
                    #line default
                }
                break;
            case 2:
                {
                    this.YoutubePlayer = (global::Windows.UI.Xaml.Controls.MediaPlayerElement)(target);
                }
                break;
            case 3:
                {
                    this.CustomMediaControl = (global::UWPYouTubePlayer.Themes.CustomMediaTransportControls)(target);
                    #line 15 "..\..\..\MainPage.xaml"
                    ((global::UWPYouTubePlayer.Themes.CustomMediaTransportControls)this.CustomMediaControl).QualityChanged += this.CustomMediaControl_QualityChangedAsync;
                    #line 15 "..\..\..\MainPage.xaml"
                    ((global::UWPYouTubePlayer.Themes.CustomMediaTransportControls)this.CustomMediaControl).CompactOverlaid += this.CustomMediaControl_CompactOverlaidAsync;
                    #line default
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}

