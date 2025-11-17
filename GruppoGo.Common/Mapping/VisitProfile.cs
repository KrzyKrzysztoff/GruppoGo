using AutoMapper;
using GruppoGo.Common.DTOs.Visits;
using GruppoGo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GruppoGo.Common.Mapping
{
    public class VisitProfile : Profile
    {
        public VisitProfile()
        {
            CreateMap<Visit, VisitDto>();
            CreateMap<Visit, SimpleVisitDto>();
        }
    }
}
