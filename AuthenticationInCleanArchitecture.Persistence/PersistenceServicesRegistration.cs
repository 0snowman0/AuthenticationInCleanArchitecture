using AuthenticationInCleanArchitecture.Application.Contracts.Generic;
using AuthenticationInCleanArchitecture.Infrasteucture.Identity.IdentityService.Abstract;
using AuthenticationInCleanArchitecture.Persistence.Repositories;
using AuthenticationInCleanArchitecture.Persistence.Repositories.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthenticationInCleanArchitecture.Persistence
{
    public static class PersistenceServicesRegistration
    {
        public static IServiceCollection ConfigurePersistenceServices(this IServiceCollection services,
            IConfiguration configuration)
        {

            services.AddDbContext<Context_En>(options =>
            {
                options.UseSqlServer(configuration
                    .GetConnectionString("DefaultConnection"));
            });

            services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));


            services.AddScoped<Iuser, User_Rep>();


            return services;
        }
    }
}
