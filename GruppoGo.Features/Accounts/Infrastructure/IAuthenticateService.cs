using GruppoGo.Common.DTOs.Accounts;
using System;
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GruppoGo.Features.Accounts.Infrastructure
{
    public interface IAuthenticateService
    {
        string GenerateTokenJwt(string email, JwtOptions jwtOptions);
    }
}
