<<<<<<< HEAD
﻿using GruppoGo.Common.DTOs.Accounts;
using System;
=======
﻿using System;
>>>>>>> aaa9ca386aa1d72b473a3f2ec65a2a0a3973826f
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GruppoGo.Features.Accounts.Infrastructure
{
    public interface IAuthenticateService
    {
<<<<<<< HEAD
        string GenerateTokenJwt(string email, JwtOptions jwtOptions);
=======
        string GenerateTokenJwt(string email);
>>>>>>> aaa9ca386aa1d72b473a3f2ec65a2a0a3973826f
    }
}
