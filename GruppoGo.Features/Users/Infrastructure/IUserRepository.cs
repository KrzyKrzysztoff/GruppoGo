using GruppoGo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GruppoGo.Features.Users.Infrastructure
{
    public interface IUserRepository
    {
        IQueryable<User> GetAll();
        Task<User> GetById(Guid Id);
    }
}
