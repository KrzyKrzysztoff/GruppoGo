using GruppoGo.Common.DTOs.Users;
using GruppoGo.Common.Reponses;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GruppoGo.Features.Users.Commands.CreateUser
{
    public record CreateUserCommand(CreateUserRequest CreateUserRequest) : IRequest<ApiResponse<UserDto>>
    {
        public string FirstName { get; set; } = CreateUserRequest.FirstName;
        public string LastName { get; set; } = CreateUserRequest.LastName;
    }
}
