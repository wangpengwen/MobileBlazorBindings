﻿using Microsoft.AspNetCore.Components;
using Microsoft.MobileBlazorBindings.Core;
using System;
using System.Threading.Tasks;
using Microsoft.MobileBlazorBindings.Elements.Handlers;
using Microsoft.MobileBlazorBindings.WebView.Elements;

namespace Microsoft.MobileBlazorBindings.Elements
{
    public class BlazorWebView : View
    {
        static BlazorWebView()
        {
            ElementHandlerRegistry
                .RegisterElementHandler<BlazorWebView>(renderer => new BlazorWebViewHandler(renderer, new MobileBlazorBindingsBlazorWebView(renderer.Dispatcher)));
        }

        [Inject] internal IServiceProvider Services { get; private set; }

#pragma warning disable CA1721 // Property names should not match get methods
        [Parameter] public RenderFragment ChildContent { get; set; }
#pragma warning restore CA1721 // Property names should not match get methods
        [Parameter] public string ContentRoot { get; set; }

        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            var element = (MobileBlazorBindingsBlazorWebView)NativeControl;

            if (firstRender)
            {
                element.ContentRoot = ContentRoot;
                element.Services = Services;
                await element.InitAsync().ConfigureAwait(false);
            }

            element.Render(ChildContent);
        }
    }
}
