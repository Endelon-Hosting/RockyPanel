using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

using RockyPanelBackend;
using RockyPanelBackend.Lang;

namespace RockyPanel
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Constants.ReadFromFile("panel.conf");
            LangProvider.Load();
            Rocky.LoadDataFromDB();
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
