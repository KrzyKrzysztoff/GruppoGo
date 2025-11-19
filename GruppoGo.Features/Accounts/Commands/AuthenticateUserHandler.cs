using GruppoGo.Common.DTOs.Accounts;
using GruppoGo.Common.Reponses;
using GruppoGo.Features.Accounts.Infrastructure;
using MediatR;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GruppoGo.Features.Accounts.Commands
{
    public class AuthenticateUserHandler(IAuthenticateService _authenticateService,
        JwtOptions _jwtOptions)
        : IRequestHandler<AuthenticateUserCommand.Command, ApiResponse<AuthenticateDto>>
    {
        public Task<ApiResponse<AuthenticateDto>> Handle(AuthenticateUserCommand.Command request, CancellationToken cancellationToken)
        {
            bool isValidSignIn = request.LoginDto.Email == "krzys@wp.pl"
                && request.LoginDto.Password == "Password123!";

            if (!isValidSignIn)
                return Task.FromResult(new ApiResponse<AuthenticateDto>(null, "False login or password", "Error message"));

            var token = _authenticateService.GenerateTokenJwt(request.LoginDto.Email, _jwtOptions);

            var authenticateDtoItems = new List<AuthenticateDto>
            {
                 new()
                {
                    AccessToken = token,
                    ExpiresIn = 3600,
                    RefreshToken = "refresh"
                }
            };

            return Task.FromResult(new ApiResponse<AuthenticateDto>(authenticateDtoItems));
        }
    }
}
