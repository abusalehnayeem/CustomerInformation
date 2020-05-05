using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace CustomerInformation.Applications.Configurations
{
    public static class ServicesConfiguration
    {
        public static IServiceCollection ConfigureRepositories(this IServiceCollection services)
        {
    //        services
  		//.AddScoped<ICustomerBankDetailRepository, CustomerBankDetailRepository>()
  		//.AddScoped<ICustomerContactDetailRepository, CustomerContactDetailRepository>()
  		//.AddScoped<ICustomerFamilyDetailRepository, CustomerFamilyDetailRepository>()
  		//.AddScoped<ICustomerPersonalDetailRepository, CustomerPersonalDetailRepository>()
  		//.AddScoped<ICustomerPhotoRepository, CustomerPhotoRepository>()
  		//.AddScoped<ICustomerRepository, CustomerRepository>()
;
            return services;
        }

        public static IServiceCollection ConfigureSupervisor(this IServiceCollection services)
        {
            //services.AddScoped<ICustomerInfoSupervisor, CustomerInfoSupervisor>();
            return services;
        }

        public static IServiceCollection AddMiddleware(this IServiceCollection services)
        {
            //services.AddMvc().AddJsonOptions(options =>
            //{
            //    options.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;
            //});
            //services.AddMvc(option => option.EnableEndpointRouting = true)
            //    .AddNewtonsoftJson(options =>
            //    {
            //        options.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();
            //        options.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;
            //    });
            return services;
        }

        public static IServiceCollection AddCorsConfiguration(this IServiceCollection services) =>        
            services.AddCors(options =>
            {
                options.AddDefaultPolicy(builder =>
                                         builder.SetIsOriginAllowed(_ => true)
                                         .AllowAnyMethod()
                                         .AllowAnyHeader()
                                         .AllowCredentials());
            }
        );
        
        public static IServiceCollection AddLogging(this IServiceCollection services)
        {
            services.AddLogging(builder => builder
                .AddConsole()
                .AddFilter(level => level >= LogLevel.Information)
            );
            return services;
        }
    }
}

