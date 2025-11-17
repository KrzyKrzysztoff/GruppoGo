using FluentValidation;
using GruppoGo.Domain.Entities;
using GruppoGo.Features.Queries.Users.GetUsers;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace GruppoGo.Features
{
    public static class DependencyInjection
    {
        public static void AddFeatures(this IServiceCollection services)
        {
            services.AddMediatR(cfg =>
                cfg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));

            services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());
            services.AddScoped<IValidator<GetUsersRequest>, GetUsersValidator>();
        }
    }
}
