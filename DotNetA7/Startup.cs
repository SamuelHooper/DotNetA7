using System;
using DotNetA7.Services;
using DotNetA7.Utils;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace DotNetA7;

internal class Startup
{
    public IServiceProvider ConfigureServices()
    {
        IServiceCollection services = new ServiceCollection();

        services.AddLogging(builder =>
        {
            builder.AddConsole();
            builder.AddFile("app.log");
        });
        services.AddTransient<IStringInterpolationService, StringInterpolationService>();
        services.AddTransient<IMainService, MainService>();
        services.AddTransient<ISystemDate, SystemDate>();

        return services.BuildServiceProvider();
    }
}
