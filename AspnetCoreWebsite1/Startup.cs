using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;

namespace AspnetCoreWebsite1
{
    public class Startup
    {
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            loggerFactory.AddConsole();

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            var osType = Environment.GetEnvironmentVariable("OS_TYPE");
            var machineName = Environment.GetEnvironmentVariable("COMPUTERNAME")
                              ?? Environment.GetEnvironmentVariable("HOSTNAME");

            app.Run(async context =>
            {
                var info = new[]
                {
                    "Hello from ASP.NET Core!",
                    $"NOW: {DateTime.Now}",
                    $"OS_TYPE: {osType}",
                    $"MACHINE: {machineName}",
                };

                context.Response.ContentType = "text/plain";
                await context.Response.WriteAsync(string.Join(Environment.NewLine, info));
            });
        }
    }
}
