using GruppoGo.Common.DTOs.Users;
using GruppoGo.Common.Reponses;
using GruppoGo.Features.Users.Infrastructure;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GruppoGo.Features.Users.Queries.GetUserById
{
    public class GetUserByIdHandler(IUserRepository userRepository) : IRequestHandler<GetUserByIdQuery.Query, ApiResponse<UserDto>>
    {

        //Validacja
        //budowanie APIRESPONES
        public Task<ApiResponse<UserDto>> Handle(GetUserByIdQuery.Query request, CancellationToken cancellationToken)
        {
            var user = userRepository.GetById(request.Id);
        }
    }
}
