using ApplySys.Application.Contracts.Persistence;
using ApplySys.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ApplySys.Persistence
{
    public static class PersistenceServicesRegisteration
    {
        public static IServiceCollection ConfigurePersistenceServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ApplyManagementDbContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("ApplySysConnectionString")));

            services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
            services.AddScoped<IApplyRepository, ApplyRepository>();

            return services;


        }
    }
}
