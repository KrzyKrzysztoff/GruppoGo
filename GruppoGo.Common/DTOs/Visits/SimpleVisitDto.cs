using GruppoGo.Common.DTOs.Passes;
using GruppoGo.Common.DTOs.Schedules;
using GruppoGo.Common.DTOs.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GruppoGo.Common.DTOs.Visits
{
    public class SimpleVisitDto
    {
        public bool WasPresent { get; set; }
        public DateTime VisitDate { get; set; }
    }
}
