using AutoMapper;
using GruppoGo.Common.DTOs.Group;
using GruppoGo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GruppoGo.Common.Mapping
{
    public class GroupProfile : Profile
    {
        public GroupProfile()
        {
            CreateMap<Group, GroupDto>();
            CreateMap<Group, SimpleGroupDto>();
        }
        
    }
}
