// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System.Reflection;
using NLog.Extensions.Hosting;
using NLog.Extensions.Logging;
using Microsoft.Extensions.DependencyInjection;

namespace LoggingExample
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }
        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
            .UseContentRoot(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location))
            .ConfigureLogging((hc, l) =>
            {
                l.ClearProviders();
                l.AddNLog(new NLogLoggingConfiguration(hc.Configuration.GetSection("Nlog")));
            })
            .ConfigureServices((hc, swc) =>
            {
                swc.AddHostedService<LoggingExampleService>();
                swc.Configure<LoggingExampleConfig>
                (hc.Configuration.GetSection("ApplicationConfig"));
            })
            .UseNLog()
            .UseConsoleLifetime();
    }
    
}
//var host = Host.CreateDefaultBuilder().UseContentRoot(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location))
//    .ConfigureLogging((hc, l) => 
//    {
//        l.ClearProviders();
//        l.AddNLog(new NLogLoggingConfiguration(hc.Configuration.GetSection("Nlog")));
//    })
//    .ConfigureServices((hc, swc) =>
//    {
        
//    };

