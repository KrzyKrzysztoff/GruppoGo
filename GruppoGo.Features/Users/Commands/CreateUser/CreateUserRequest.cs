using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GruppoGo.Features.Users.Commands.CreateUser
{
    public class CreateUserRequest(string firstName, string lastName)
    {
        public string FirstName { get; set; } = firstName;
        public string LastName { get; set; } = lastName;
    }
}
