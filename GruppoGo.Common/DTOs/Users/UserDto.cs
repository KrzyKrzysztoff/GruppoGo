using GruppoGo.Common.DTOs.Group;
using GruppoGo.Common.DTOs.Passes;
using GruppoGo.Common.DTOs.Visits;
using GruppoGo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GruppoGo.Common.DTOs.Users
{
    public class UserDto
    {
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Login { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public IEnumerable<SimpleGroupDto> Groups { get; set; } = [];
        public IEnumerable<SimplePassDto> Passes { get; set; } = [];
        public IEnumerable<SimpleVisitDto> Visits { get; set; } = [];
    }
}
