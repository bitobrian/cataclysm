using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Ocelot.Middleware;
using System.IO;

namespace gateway.api
{
    public class Program
    {
        public static void Main(string[] args)
        {
            new WebHostBuilder()
            .UseKestrel()
            .UseContentRoot(Directory.GetCurrentDirectory())
            .ConfigureAppConfiguration((hostingContext, config) =>
            {
                config
                    .SetBasePath(hostingContext.HostingEnvironment.ContentRootPath)
                    .AddJsonFile("appsettings.json", true, true)
                    .AddJsonFile($"appsettings.{hostingContext.HostingEnvironment.EnvironmentName}.json", true, true)
                    .AddJsonFile(Path.Combine("configuration", "ocelot.json"), optional: false, reloadOnChange: true)
                    .AddEnvironmentVariables();
            })
            .UseStartup<Startup>()
            .ConfigureLogging((hostingContext, logging) =>
            {
                // TODO: Add logging
            })
            .Build()
            .Run();
        }
    }
}
