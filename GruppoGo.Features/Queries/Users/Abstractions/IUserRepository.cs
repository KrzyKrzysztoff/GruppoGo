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
        IQueryable<User> GetAll(int page, int size);
    }
}
