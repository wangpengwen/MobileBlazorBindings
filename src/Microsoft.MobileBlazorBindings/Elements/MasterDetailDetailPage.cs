﻿using Microsoft.MobileBlazorBindings.Elements.Handlers;
using Emblazon;
using XF = Xamarin.Forms;

namespace Microsoft.MobileBlazorBindings.Elements
{
#pragma warning disable CA1812 // Internal class that is apparently never instantiated; this class is instantiated generically
    internal class MasterDetailDetailPage : ContentPage
#pragma warning restore CA1812 // Internal class that is apparently never instantiated
    {
        static MasterDetailDetailPage()
        {
            ElementHandlerRegistry
                .RegisterElementHandler<MasterDetailDetailPage>(renderer => new DetailPageHandler(renderer, new XF.ContentPage()));
        }
    }
}
