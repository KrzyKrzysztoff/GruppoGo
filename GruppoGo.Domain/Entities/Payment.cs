using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GruppoGo.Domain.Entities
{
    public class Payment
    {
        public Guid Id { get; set; }
        public decimal NetValue { get; set; }
        public decimal TaxValue { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public Pass Pass { get; set; } = default!;
        public User User { get; set; } = default!;

    }
}
