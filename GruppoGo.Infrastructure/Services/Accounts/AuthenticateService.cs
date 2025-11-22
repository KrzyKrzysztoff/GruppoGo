<<<<<<< HEAD
﻿using GruppoGo.Common.DTOs.Accounts;
using GruppoGo.Features.Accounts.Infrastructure;
=======
﻿using GruppoGo.Features.Accounts.Infrastructure;
>>>>>>> aaa9ca386aa1d72b473a3f2ec65a2a0a3973826f
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Net;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace GruppoGo.Infrastructure.Services.Accounts
{
    public class AuthenticateService : IAuthenticateService
    {
<<<<<<< HEAD
        public string GenerateTokenJwt(string email, JwtOptions jwtOptions)
=======
        public string GenerateTokenJwt(string email)
>>>>>>> aaa9ca386aa1d72b473a3f2ec65a2a0a3973826f
        {
            var claims = new[]
            {
                new Claim(JwtRegisteredClaimNames.Sub, email),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
            };

<<<<<<< HEAD
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(jwtOptions.SecretKey));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(
                issuer: jwtOptions.Issuer,
                audience: jwtOptions.Audience,
=======
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("your_super_secret_key"));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(
                issuer: "yourdomain.com",
                audience: "yourdomain.com",
>>>>>>> aaa9ca386aa1d72b473a3f2ec65a2a0a3973826f
                claims: claims,
                expires: DateTime.Now.AddMinutes(30),
                signingCredentials: creds);

            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}
