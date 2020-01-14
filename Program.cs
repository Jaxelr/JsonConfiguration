using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Diagnostics;

namespace JsonConfiguration
{
    internal class Program
    {
        private IConfiguration Configuration { get; set; }

        private static void Main(string[] args)
        {
            IConfiguration config = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json", true, true)
                .Build();

            //Extract the AppSettings information from the appsettings config.
            var settings = new AppSettings();
            config.GetSection(nameof(AppSettings)).Bind(settings);

            var serviceProvider = new ServiceCollection()
                .AddSingleton(settings)
                .AddSingleton<IClient, Client>()
                .BuildServiceProvider();

            var client = serviceProvider.GetService<IClient>();

            client.WriteSettings();

            if (Debugger.IsAttached)
                Console.Read();
        }
    }
}