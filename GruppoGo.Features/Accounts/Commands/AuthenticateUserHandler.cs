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
    public class AuthenticateUserHandler(IAuthenticateService _authenticateService)
        : IRequestHandler<AuthenticateUserCommand.Command, ApiResponse<AuthenticateDto>>
    {
        public Task<ApiResponse<AuthenticateDto>> Handle(AuthenticateUserCommand.Command request, CancellationToken cancellationToken)
        {
            bool isValidSignIn = request.LoginDto.Email == "1"
                && request.LoginDto.Password == "1";
      

            if (!isValidSignIn)
                return Task.FromResult(new ApiResponse<AuthenticateDto>(null, "False login or password", "Error message"));

            var jwtOptions = new JwtOptions
            {
                Audience = "www.test.org",
                Issuer = "www.test.org",
                SecretKey = "secret"
            };

            var token = _authenticateService.GenerateTokenJwt(request.LoginDto.Email, jwtOptions);

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
