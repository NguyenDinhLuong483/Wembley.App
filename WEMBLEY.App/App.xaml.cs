using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Configuration;
using System.Data;
using System.Text;
using System.Windows;
using WEMBLEY.App.HostBuiders;

namespace WEMBLEY.App
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private readonly IHost _host;
        public App()
        {
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            _host = CreateHostBuilder().Build();
        }

#pragma warning disable CS8625 // Cannot convert null literal to non-nullable reference type.
        public static IHostBuilder CreateHostBuilder(string[] args = null)
#pragma warning restore CS8625 // Cannot convert null literal to non-nullable reference type.
        {
            return Host.CreateDefaultBuilder(args)
                .AddServices()
                .AddViewModels()
                .AddNavigation();
        }
        protected override void OnStartup(StartupEventArgs e)
        {
            _host.Start();

            MainWindow window = _host.Services.GetRequiredService<MainWindow>();
            window.Show();

            base.OnStartup(e);
        }

        protected override async void OnExit(ExitEventArgs e)
        {
            await _host.StopAsync();
            _host.Dispose();

            base.OnExit(e);
        }
    }

}
