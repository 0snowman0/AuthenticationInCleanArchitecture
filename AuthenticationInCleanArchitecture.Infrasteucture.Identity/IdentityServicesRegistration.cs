using AuthenticationInCleanArchitecture.Infrasteucture.Identity.IdentityService.Abstract;
using AuthenticationInCleanArchitecture.Infrasteucture.Identity.IdentityService.Implement;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AuthenticationInCleanArchitecture.Infrasteucture.Identity
{
    public static class IdentityServicesRegistration
    {
        public static void ConfigureIdentityServices(this IServiceCollection services)
        {
            services.AddAutoMapper(Assembly.GetExecutingAssembly());

            services.AddMediatR(Assembly.GetExecutingAssembly());


            services.AddScoped<IUserService, UserService>();

        }
    }
}
