using GruppoGo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GruppoGo.Features.Queries.Users.Abstractions
{
    public interface IUserRepository
    {
        Task<List<User>> GetAllAsync(int page, int size);
    }
}
