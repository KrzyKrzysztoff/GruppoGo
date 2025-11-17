using GruppoGo.Common.DTOs.Passes;
using GruppoGo.Common.DTOs.Schedules;
using GruppoGo.Common.DTOs.Users;
using GruppoGo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GruppoGo.Common.DTOs.Visits
{
    public class VisitDto
    {
        public bool WasPresent { get; set; }
        public DateTime VisitDate { get; set; }
        public ScheduleDto Schedule { get; set; } = new();
        public UserDto User { get; set; } = new();
        public PassDto Pass { get; set; } = new();
    }
}
