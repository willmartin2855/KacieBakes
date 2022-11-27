using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoggingExample
{
    public class LoggingExampleService : BackgroundService
    {
        private readonly ILogger<LoggingExampleService> _logger;
        private readonly LoggingExampleConfig _config;
        private readonly IHostApplicationLifetime _lifetime;
        public LoggingExampleService(ILogger<LoggingExampleService> logger, IOptionsMonitor<LoggingExampleConfig> config, IHostApplicationLifetime lifetime)
        {
            _logger = logger;
            _config = config.CurrentValue;
            _lifetime = lifetime;
        }
        protected override Task ExecuteAsync(CancellationToken stoppingToken)
        {
            _logger.LogDebug("I'm logging!");
            Console.WriteLine(_config.ConfiguredMessage);
            Console.ReadKey();
            return Task.CompletedTask;
        }
    }
}
