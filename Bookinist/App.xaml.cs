using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Windows;

namespace Bookinist
{
    public partial class App : Application
    {
        private static IHost __Host; // use pattern singleton

        // Первое обращение к этому публичному статическому свойству Host
        // заставит этот Host создаться
        // с помощью метода CreateHostBuilder

        // последующие обращения будут переадреованны к полю __Host,
        // которое будет заполнено при первом обращение к нему
        public static IHost Host => __Host
            ??= Program.CreateHostBuilder(Environment.GetCommandLineArgs()).Build();

        // создаем возможность доступа к сервисам посредствам хоста
        // если обращение к сервисам будет раньше, чем заплонировалось, то
        // это все равно приведет к создаю хоста
        public static IServiceProvider Service => Host.Services;

        internal static void ConfigureServices(HostBuilderContext host, IServiceCollection services)
        {
            throw new NotImplementedException();
        }


        // Запуск хоста
        protected override async void OnStartup(StartupEventArgs e)
        {
            var host = Host;
            base.OnStartup(e);
            await host.StartAsync();
        }

        // Остановка хоста
        protected override async void OnExit(ExitEventArgs e)
        {
            using var host = Host;
            base.OnExit(e);
            await host.StopAsync();
        }
    }
}

