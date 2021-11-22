using LeasingRazor.Domain;
using LeasingRazor.Persistence.Context;
using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
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

            services.AddIdentity<ApplicationUser, IdentityRole>(options => options.SignIn.RequireConfirmedAccount = true)
                .AddEntityFrameworkStores<LeasingRazorDbContext>().AddDefaultUI().AddDefaultTokenProviders();

   //         services.AddIdentity<ApplicationUser, IdentityRole>(options => options.SignIn.RequireConfirmedAccount = true)
   //        .AddEntityFrameworkStores<AccountingDbContext>()
   //        .AddDefaultUI()
   //.AddDefaultTokenProviders();

            services.AddMediatR(Assembly.GetExecutingAssembly());
            return services;
        }
    }
}
