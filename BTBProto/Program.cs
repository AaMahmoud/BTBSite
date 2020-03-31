using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace BTBProto
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //      var configuration = new ConfigurationBuilder()
            //.AddCommandLine(args)
            //.Build();

            //      var hostUrl = configuration["hosturl"];
            //      if (string.IsNullOrEmpty(hostUrl))
            //          hostUrl = "https://0.0.0.0:5001";


            //      using var host = new WebHostBuilder()
            //          .UseKestrel()
            //          .UseUrls(hostUrl)   // <!-- this 
            //          .UseContentRoot(Directory.GetCurrentDirectory())
            //          .UseIISIntegration()
            //          .UseStartup<Startup>()
            //          .UseConfiguration(configuration)
            //          .Build();

            //      host.Run();
            CreateHostBuilder(args).Build().Run();
            // use this to allow command line parameters in the config


        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
