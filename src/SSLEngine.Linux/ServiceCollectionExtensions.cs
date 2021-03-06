﻿using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using SSLEngine.Abstraction;
using System;
using System.Collections.Generic;

namespace SSLEngine.Linux
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddLinuxSSL(this IServiceCollection source)
        {
            if (source == null)
                throw new ArgumentNullException(nameof(source));

            source.TryAdd(GetWindowsServices());

            return source;
        }

        private static IEnumerable<ServiceDescriptor> GetWindowsServices()
        {
            yield return ServiceDescriptor.Singleton<ISSLResourceHandler, SSLResourceHandler>();
        }
    }
}
