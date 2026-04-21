using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.DependencyInjection;
using System;
using GenericHost;

HostApplicationBuilder builder = Host.CreateApplicationBuilder(args);

builder.Services.AddHostedService<HostedService>();
builder.Services.AddHostedService<MonitoringService>();

builder.Logging.ClearProviders();
builder.Logging.AddConsole();

using IHost host = builder.Build();
host.Run();

Console.WriteLine("Host has terminated. Press any key to finish the app.");
Console.ReadKey();
