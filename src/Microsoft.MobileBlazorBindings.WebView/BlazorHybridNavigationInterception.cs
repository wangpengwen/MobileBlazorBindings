﻿using Microsoft.AspNetCore.Components.Routing;
using System.Threading.Tasks;

namespace Microsoft.Extensions.DependencyInjection
{
#pragma warning disable CA1812 // Internal class that is apparently never instantiated; this class is instantiated generically
    internal class BlazorHybridNavigationInterception : INavigationInterception
#pragma warning restore CA1812 // Internal class that is apparently never instantiated
    {
        public Task EnableNavigationInterceptionAsync()
        {
            // We don't actually need to set anything up in this environment
            return Task.CompletedTask;
        }
    }
}
