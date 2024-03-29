﻿using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WEMBLEY.App.Core.Application.ViewModels.Home;
using WEMBLEY.App.Core.Application.ViewModels.SeedWork;

namespace WEMBLEY.App.HostBuiders
{
    public static class AddNavigationHostBuilderExtension
    {
        public static IHostBuilder AddNavigation(this IHostBuilder host)
        {
            host.ConfigureServices(services =>
            {
                services.AddSingleton<Func<Type, BaseViewModel>>((IServiceProvider serviceProvider)
                    => viewModelType => (BaseViewModel)serviceProvider.GetRequiredService(viewModelType));
            });

            return host;
        }
    }
}
