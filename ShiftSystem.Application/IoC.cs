using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using ShiftSystem.Application.Person.Handlers;
using ShiftSystem.Application.Queue.Handlers;
using ShiftSystem.Application.QueuePerson.Handlers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ShiftSystem.Application
{
    public static class IoC
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddTransient<IPersonHandler, PersonHandler>();
            services.AddTransient<IQueueHandler, QueueHandler>();
            services.AddTransient<IQueuePersonHandler, QueuePersonHandler>();

            services.AddAutoMapper(Assembly.GetExecutingAssembly());

            services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());

            return services;
        }
    }
}
