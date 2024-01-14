using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WEMBLEY.App;
using WEMBLEY.App.Core.Application.ViewModels;
using WEMBLEY.App.Core.Application.ViewModels.Home;
using WEMBLEY.App.Core.Application.ViewModels.Line1;
using WEMBLEY.App.Core.Application.ViewModels.MachinesInLine;
using WEMBLEY.App.Core.Application.ViewModels.Line1.StopperMachineDetail;
using WEMBLEY.App.Core.Application.ViewModels.Line1.StopperMachineMFC;
using WEMBLEY.App.Core.Application.ViewModels.Line1.StopperMachineReport;
using WEMBLEY.App.Core.Application.ViewModels.Line1.StopperMachineStatus;

namespace WEMBLEY.App.HostBuiders
{
    public static class AddViewModelsHostBuilderExtension
    {
        public static IHostBuilder AddViewModels(this IHostBuilder host)
        {
            host.ConfigureServices(services =>
            {
                //Home
                services.AddTransient<HomeNavigationViewModel>();
                services.AddTransient<HomeViewModel>();
                services.AddTransient<LineInitialSettingViewModel>();

                //Line1
                services.AddTransient<StopperMachineDetailViewModel>();
                services.AddTransient<StopperMachineFaultHistoryViewModel>();
                services.AddTransient<StopperMachineMonitorViewModel>();

                services.AddTransient<MFCMonitorViewModel>();
                services.AddTransient<MFCNavigationViewModel>();
                services.AddTransient<MFCSettingViewModel>();

                services.AddTransient<ReportForShiftViewModel>();
                services.AddTransient<ReportLongTimeViewModel>();
                services.AddTransient<ReportNavigationViewModel>();

                services.AddTransient<StopperMachineStatusViewModel>();

                services.AddTransient<StopperMachineViewModel>();

                //MachineInLine
                services.AddTransient<MachinesInLine1ViewModel>();

                //Main
                services.AddTransient<MainViewModel>();
                services.AddSingleton<MainWindow>((IServiceProvider serviceProvider) => new MainWindow
                {
                    DataContext = serviceProvider.GetRequiredService<MainViewModel>()
                });
            });

            return host;
        }
    }
}
