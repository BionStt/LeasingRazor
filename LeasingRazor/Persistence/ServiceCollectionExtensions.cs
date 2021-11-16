using LeasingRazor.Persistence.Context;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace LeasingRazor.Persistence
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddLeasingRazor(this IServiceCollection services, string connectionString)
        {

            services.AddDbContext<LeasingRazorDbContext>(options =>
              options.UseSqlServer(connectionString));

            services.AddMediatR(Assembly.GetExecutingAssembly());
            return services;
        }
    }
}
