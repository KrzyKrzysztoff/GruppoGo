using GruppoGo.Common.DTOs.Accounts;
using GruppoGo.Features.Accounts.Infrastructure;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace GruppoGo.Infrastructure.Services.Accounts
{
    public class AuthenticateService : IAuthenticateService
    {
        public string GenerateTokenJwt(string email, JwtOptions jwtOptions)
        {
            try
            {
                var claims = new[]
               {
                    new Claim(JwtRegisteredClaimNames.Sub, email),
                    new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
                };

                var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(jwtOptions.SecretKey));
                var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

                var token = new JwtSecurityToken(
                    issuer: jwtOptions.Issuer,
                    audience: jwtOptions.Audience,
                    claims: claims,
                    expires: DateTime.Now.AddMinutes(30));

                return new JwtSecurityTokenHandler().WriteToken(token);
            }
            catch (Exception ex)
            {
                throw;
            }

        }
    }
}
