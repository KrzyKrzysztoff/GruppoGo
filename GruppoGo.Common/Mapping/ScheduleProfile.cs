using AutoMapper;
using GruppoGo.Common.DTOs.Schedules;
using GruppoGo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace GruppoGo.Common.Mapping
{
    public class ScheduleProfile : Profile
    {
        public ScheduleProfile()
        {
            CreateMap<Schedule, ScheduleDto>();
            CreateMap<Schedule, SimpleScheduleDto>();
        }
    }
}
