using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GruppoGo.Domain.Entities
{
    public class Visit
    {
        public Guid Id { get; set; }

        public bool WasPresent { get; set; }
        public DateTime VisitDate { get; set; } = DateTime.UtcNow;

        public Schedule Schedule { get; set; } = default!;
        public User User { get; set; } = default!;
        public Pass Pass { get; set; } = default!;
    }
}
