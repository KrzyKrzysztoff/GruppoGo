using GruppoGo.Common.DTOs.Schedules;
using GruppoGo.Common.DTOs.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GruppoGo.Common.DTOs.Group
{
    public class GroupDto
    {
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public SimpleUserDto Leader { get; set; } = new SimpleUserDto();
        public IEnumerable<SimpleUserDto> Members { get; set; } = [];
        public IEnumerable<ScheduleDto> Schedules { get; set; } = [];
    }
}
