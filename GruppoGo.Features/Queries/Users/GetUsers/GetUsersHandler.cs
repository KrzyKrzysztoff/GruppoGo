using GruppoGo.Common.DTOs;
using GruppoGo.Features.Queries.Users.Abstractions;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AutoMapper;

namespace GruppoGo.Features.Queries.Users.GetUsers
{
    public class GetUsersHandler(IUserRepository _userRepository
        ,IMapper _mapper) : IRequestHandler<GetUsersQuery.Query, IEnumerable<UserDto>>
    {
        public async Task<IEnumerable<UserDto>> Handle(GetUsersQuery.Query request,
            CancellationToken cancellationToken)
        {

            var result = await  _userRepository
                .GetAll(2,2)
                .ToListAsync(cancellationToken);

            var resultDto =_mapper.Map<IEnumerable<UserDto>>(result);

            return resultDto;
        }
    }
}
