using System;
using System.Reflection;

using AutoMapper;

using IoTSolution.API.API.Common.Settings;
using IoTSolution.API.IoC.Configuration.AutoMapper;
using IoTSolution.API.Services;
using IoTSolution.API.Services.Contracts;

using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;


namespace IoTSolution.API.IoC.Configuration.DI
{
    public static class ServiceCollectionExtensions
    {
        public static void ConfigureBusinessServices(this IServiceCollection services, IConfiguration configuration)
        {
            if (services != null)
            {
                var appSettingsSection = configuration.GetSection(nameof(AppSettings));
                if (appSettingsSection == null)
                    throw new System.Exception("No appsettings section has been found");

                var appSettings = appSettingsSection.Get<AppSettings>();

                if (!appSettings.IsValid())
                    throw new Exception("No valid settings.");

                services.Configure<AppSettings>(appSettingsSection);

                services.AddTransient<IDeviceManagementService, DeviceManagementService>();
                services.AddTransient<IIoTHubC2DOperationsService, IoTHubC2DOperationsService>();
            }
        }

        public static void ConfigureMappings(this IServiceCollection services)
        {
            if (services != null)
            {
                //Automap settings
                services.AddAutoMapper(Assembly.GetExecutingAssembly());
                MappingConfigurationsHelper.ConfigureMapper();
            }
        }
    }
}
