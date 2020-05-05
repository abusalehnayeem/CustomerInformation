using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using CustomerInformation.Applications.Common.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CustomerInformation.Data
{
    public static class CustomerDependencyInjection
    {
        public static IServiceCollection AddDbServiceCollection(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<CustomerInformationContext>(options =>
                options.UseSqlServer(
                    configuration.GetConnectionString("DefaultConnection")));
            services.AddScoped<ICustomerInformationContext>(provider =>
                provider.GetService<CustomerInformationContext>());
            return services;
        }
    }
}
