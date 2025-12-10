using GruppoGo.Domain.Entities;
using GruppoGo.Features.Users.Infrastructure;
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
        public IQueryable<User> GetAll()
        {
            var users = _dbContext
                .Users
                .Include(x => x.Groups)
                .Include(x => x.Passes)
                .Include(x => x.Visits);

            return users;
        }

        public async Task<User?> GetByIdAsync(Guid Id)
        {
            var user = await _dbContext
                .Users
                .Include(x => x.Groups)
                .Include(x => x.Passes)
                .Include(x => x.Visits)
                .FirstOrDefaultAsync();
            
            return user;
        }
    }
}
