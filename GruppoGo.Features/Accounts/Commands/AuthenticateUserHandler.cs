using GruppoGo.Common.DTOs.Accounts;
using GruppoGo.Common.Reponses;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GruppoGo.Features.Accounts.Commands
{
    public class AuthenticateUserHandler : IRequestHandler<AuthenticateUserCommand.Command, ApiResponse<AuthenticateDto>>
    {
        public Task<ApiResponse<AuthenticateDto>> Handle(AuthenticateUserCommand.Command request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
