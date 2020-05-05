using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CustomerInformation.Applications.Configurations
{
    public static class ConfigureConnections
    {
        public static IServiceCollection AddConnectionProvider(this IServiceCollection services, IConfiguration configuration)
        {
            //var connection = string.Empty;
            //if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            //{
            //    connection = configuration.GetConnectionString("HanaErpDbWindows") ??
            //                     "Server=127.0.0.1\\SqlExpress;Database=CustomerInformation;User id=sa;Password=Sa@123456;MultipleActiveResultSets=True;";
            //}
            //else if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux) || RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
            //{
            //    connection = configuration.GetConnectionString("HanaErpDbDocker") ??
            //                     "Server=localhost,1433;Database=HanaErp;User=sa;Password=Pa55w0rd;Trusted_Connection=False;Application Name=HanaErpASPNETCoreAPINTier";
            //}

            //services.AddDbContextPool<Customer>(options => options.UseSqlServer(connection));
            //services.AddSingleton(new DbInfo(connection));
            return services;
        }
    }
}
