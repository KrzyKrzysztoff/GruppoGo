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
    public static class AuthenticateUserCommand
    {
        public record Command(LoginDto LoginDto) : IRequest<ApiResponse<AuthenticateDto>>;
    }
}
