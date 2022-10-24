using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ShiftSystem.Application.Interfaces;
using ShiftSystem.Infrastructure.Context;
using ShiftSystem.Infrastructure.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShiftSystem.Infrastructure
{
    public static class IoC
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddTransient<IPersonService, PersonService>();
            services.AddTransient<IQueueService, QueueService>();
            services.AddTransient<IQueuePersonService, QueuePersonService>();
            services.AddTransient<IShiftSystemDbContext, ShiftSystemDbContext>();

            services.AddDbContext<ShiftSystemDbContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("ShiftSystemdb")));

            return services;


        }
    }
}
