using GruppoGo.Common.DTOs.Users;
using GruppoGo.Common.Reponses;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GruppoGo.Features.Queries.Users.GetUserById
{
    public class GetUserByIdHandler() : IRequestHandler<GetUserByIdQuery.Query, ApiResponse<UserDto>>
    {

        //Validacja
        //budowanie APIRESPONES
        public Task<ApiResponse<UserDto>> Handle(GetUserByIdQuery.Query request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
