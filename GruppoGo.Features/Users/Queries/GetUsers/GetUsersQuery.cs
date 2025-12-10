using GruppoGo.Common.DTOs.Users;
using GruppoGo.Common.Reponses;
using GruppoGo.Features.Users.Queries.GetUsers;
using MediatR;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GruppoGo.Features.Queries.Users.GetUsers
{
    public static class GetUsersQuery
    {
        public record Query(GetUsersRequest GetUsersRequest) : IRequest<ApiResponse<UserDto>>;
 
    }
}
