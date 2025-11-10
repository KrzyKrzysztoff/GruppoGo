using GruppoGo.Domain.Entities;
using GruppoGo.Features.Queries.Users.Abstractions;
using GruppoGo.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GruppoGo.Infrastructure.Repositories.Users
{
    public class UserRepository(AppDbContext _dbContext) : IUserRepository
    {
        public IQueryable<User> GetAll(int page, int size)
        {
            var users =  _dbContext
                .Users
                .Skip((page - 1) * size)
                .Take(size)
                .OrderBy(x => x.FirstName);

            return users;
        }
    }
}
