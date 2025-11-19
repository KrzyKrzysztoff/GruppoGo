using GruppoGo.Common.Mapping;
using Microsoft.Extensions.DependencyInjection;
using AutoMapper;

namespace GruppoGo.Common
{
    public static class DependecyInjection
    {
        public static void AddCommon(this IServiceCollection services)
        {
            services.AddAutoMapper(x=>x.AddProfile(typeof(UserProfile)));
            services.AddAutoMapper(x=>x.AddProfile(typeof(GroupProfile)));
            services.AddAutoMapper(x=>x.AddProfile(typeof(VisitProfile)));
            services.AddAutoMapper(x=>x.AddProfile(typeof(PassProfile)));
            services.AddAutoMapper(x=>x.AddProfile(typeof(ScheduleProfile)));

        }
    }
}
