﻿using ViewMarkdown.Forms.Plugin.Abstractions;
using ViewMarkdown.Forms.Plugin.WinStore;
using Xamarin.Forms;

[assembly: Dependency(typeof(WebViewBaseUrl))]
namespace ViewMarkdown.Forms.Plugin.WinStore
{
    public class WebViewBaseUrl : IWebViewBaseUrl
    {
        public string Url
        {
            get { return "ms-appx-web:///Assets/"; }
        }
    }
}
