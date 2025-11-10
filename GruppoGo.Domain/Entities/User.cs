using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GruppoGo.Domain.Entities
{
    public class User : Account
    {
        public string FirstName { get; set; } = default!;
        public string LastName { get; set; } = default!;
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public ICollection<Group> Groups { get; set; } = [];
        public ICollection<Pass> Passes { get; set; } = [];
        public ICollection<Visit> Visits { get; set; } = [];
        public ICollection<Group> LeadedGroups { get; set; } = [];
    }
}
