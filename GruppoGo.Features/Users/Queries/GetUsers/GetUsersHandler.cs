using AutoMapper;
using FluentValidation;
using GruppoGo.Common.DTOs.Users;
using GruppoGo.Common.Reponses;
using GruppoGo.Features.Queries.Users.GetUsers;
using GruppoGo.Features.Users.Infrastructure;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

            var result =  _userRepository.GetAll();

            var filtredResult = await result
                .OrderBy(x => x.FirstName)
                .Skip((request.GetUsersRequest.Size - 1) * request.GetUsersRequest.Size)
                .Take(request.GetUsersRequest.Size)
                .ToListAsync(cancellationToken: cancellationToken);

            var resultDto = _mapper.Map<ICollection<UserDto>>(filtredResult);

            return new ApiResponse<UserDto>(resultDto);
        }
    }
}
