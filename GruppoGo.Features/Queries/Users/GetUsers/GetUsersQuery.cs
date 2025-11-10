using GruppoGo.Common.DTOs;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GruppoGo.Features.Queries.Users.GetUsers
{
    public static class GetUsersQuery
    {
        public record Query : IRequest<IEnumerable<UserDto>>;
    }
}
