using GruppoGo.Features.Users.Infrastructure;
using GruppoGo.Infrastructure.Persistence;
using GruppoGo.Infrastructure.Repositories.Users;
using GruppoGo.Infrastructure.Seed;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GruppoGo.Infrastructure
{
    public static class DependecyInjection
    {
        public static void AddInfrastructure(this IServiceCollection services,
            IConfiguration configuration)
        {

           var connectionString = configuration.GetConnectionString("DefaultConnection")
                ?? throw new Exception("Invalid connection string");

            services.AddDbContext<AppDbContext>(options =>
                options.UseSqlServer(connectionString)
            );

            services.AddScoped<DbSeed>();
            services.AddScoped<IUserRepository, UserRepository>();

        }
    }
}
