using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ApplySys.Application
{
    public static class ApplicationServicesRegistration
    {

        //Register our AutoMapper in our dependency injection
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddAutoMapper(Assembly.GetExecutingAssembly());

            services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));


            return services;
        }
    }
}

            //services.AddMediatKR(Assembly.GetExecutingAssembly());