using System;
using App.Metrics;
using App.Metrics.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace MediumGrafanaArticleExample
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).UseMetricsWebTracking().Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureMetricsWithDefaults(builder =>
                {
                    builder.Report.ToInfluxDb("http://127.0.0.1:8086","MediumArticleDemo",TimeSpan.FromSeconds(5));
                })
                .UseMetrics()
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
