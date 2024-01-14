using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WEMBLEY.App.Core.Application.Services;
using WEMBLEY.App.Core.Domain.Services;

namespace WEMBLEY.App.HostBuiders
{
    public static class AddServicesHostBuilderExtension
    {
        public static IHostBuilder AddServices(this IHostBuilder host)
        {
            host.ConfigureServices(services =>
            {
                services.AddSingleton<INavigationService, NavigationService>();
                services.AddSingleton<IApiService, ApiService>();
            });
            return host;
        }
    }
}
