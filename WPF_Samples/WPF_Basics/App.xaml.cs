using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Windows;
using WPF_Basics.Models;
using WPF_Basics.ViewModels;
using Microsoft.Extensions.Logging;
using WPF_Basics.DI;

namespace WPF_Basics
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private IHost _host;

        public App()
        {
            _host = Host.CreateDefaultBuilder()
                .ConfigureLogging(opts=> {
                    opts.AddDebug();
                })
                .ConfigureServices(ConfigureServices)
                .Build();
        }

        private void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<IPersonRepository, FakePersonRepository>(); 
            services.AddSingleton<MainWindow>();
            services.AddTransient<BindingViewModel>();

            services.AddSingleton<IViewContainer, ViewContainer>();
        }

        private void OnStartup(object sender, StartupEventArgs args)
        {
            _host.Start();
            var main = _host.Services.GetService<MainWindow>();
            main.Show();
        }
    }
}
