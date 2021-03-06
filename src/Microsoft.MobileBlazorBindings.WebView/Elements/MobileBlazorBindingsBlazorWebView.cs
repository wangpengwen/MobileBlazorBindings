﻿using Microsoft.AspNetCore.Components;

namespace Microsoft.MobileBlazorBindings.WebView.Elements
{
    public class MobileBlazorBindingsBlazorWebView : BlazorWebView<IComponent>
    {
        public MobileBlazorBindingsBlazorWebView(Dispatcher dispatcher)
            : base(dispatcher, initOnParentSet: false)
        {
        }
    }
}
