using GruppoGo.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GruppoGo.Domain.Entities
{
    public class Pass
    {
        public Guid Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public PassTypeEnum Type { get; set; }
        public DateTime StartAt { get; set; }
        public DateTime EndAt { get; set; }
        public int RemainingVisits { get; set; }

        public User User { get; set; } = default!;
        public ICollection<Visit> Visits { get; set; } = [];

    }
}
