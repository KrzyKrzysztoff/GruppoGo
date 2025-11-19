using GruppoGo.Common.Reponses;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AutoMapper;
using FluentValidation;
using GruppoGo.Common.DTOs.Users;
using GruppoGo.Features.Users.Infrastructure;
using GruppoGo.Features.Queries.Users.GetUsers;

namespace GruppoGo.Features.Users.Queries.GetUsers
{
    public class GetUsersHandler(IUserRepository _userRepository
        , IMapper _mapper
        , IValidator<GetUsersRequest> _validator) : IRequestHandler<GetUsersQuery.Query, ApiResponse<UserDto>>
    {
        public async Task<ApiResponse<UserDto>> Handle(GetUsersQuery.Query request,
            CancellationToken cancellationToken)
        {

            //var result2 = _validator.ValidateAsync(request.GetUsersRequest); // do middleware todo

            var result = await _userRepository
                .GetAllAsync(request.Page, request.Size);

            var resultDto = _mapper.Map<IEnumerable<UserDto>>(result);

            return new ApiResponse<UserDto>(resultDto);
        }
    }
}
