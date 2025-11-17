using GruppoGo.Common.DTOs.Users;
using GruppoGo.Common.DTOs.Visits;
using GruppoGo.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GruppoGo.Common.DTOs.Passes
{
    public class PassDto
    {
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public PassTypeEnum Type { get; set; }
        public DateTime StartAt { get; set; }
        public DateTime EndAt { get; set; }
        public int RemainingVisits { get; set; }
        public UserDto User { get; set; } = new();
        public IEnumerable<VisitDto> Visits { get; set; } = Enumerable.Empty<VisitDto>();
    }
}
