using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace Sf.ContractApi.WebApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var webHost = CreateWebHostBuilder(args);

            // optionally add additional configuration by using 
            //  the ConfigureAppConfiguration method and passing a delegate
            webHost.ConfigureAppConfiguration((context, config) =>
            {
                // nothing for now
            });

            // optionally add logging configuration
            webHost.ConfigureLogging((context, logger) =>
            {
                // DefaultBuilder includes Console, Debugger
                logger.AddAzureWebAppDiagnostics();
                
            });

            webHost                
                .Build()
                .Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseApplicationInsights()
                .UseStartup<Startup>();
    }
}
