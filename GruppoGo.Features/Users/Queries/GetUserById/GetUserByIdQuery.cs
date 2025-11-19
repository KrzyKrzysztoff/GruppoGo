using GruppoGo.Common.DTOs.Users;
using GruppoGo.Common.Reponses;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GruppoGo.Features.Users.Queries.GetUserById
{
    public class GetUserByIdQuery
    {
        public record Query(GetUserByIdRequest request) : IRequest<ApiResponse<UserDto>>
        {
            public Guid Id { get; set; } = request.Id;
        }
    }
}
