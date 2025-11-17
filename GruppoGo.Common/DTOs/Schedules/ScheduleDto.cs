using GruppoGo.Common.DTOs.Group;
using GruppoGo.Common.DTOs.Visits;
using GruppoGo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GruppoGo.Common.DTOs.Schedules
{
    public class ScheduleDto
    {
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }

        public GroupDto Group { get; set; } = new();
        public IEnumerable<VisitDto> Visits { get; set; } = Enumerable.Empty<VisitDto>().ToList();
    }
}
