using AutoMapper;
using GruppoGo.Common.DTOs.Passes;
using GruppoGo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GruppoGo.Common.Mapping
{
    public class PassProfile : Profile
    {
        public PassProfile()
        {
            CreateMap<Pass, PassDto>();
            CreateMap<Pass, SimplePassDto>();
        }
    }
}
