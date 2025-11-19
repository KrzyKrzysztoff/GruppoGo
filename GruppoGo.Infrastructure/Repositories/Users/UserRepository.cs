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
        public async Task<List<User>> GetAllAsync(int page, int size)
        {
            var users =  await _dbContext
                .Users
                .Include(x=>x.Groups)
                .Include(x=>x.Passes)
                .Include(x=>x.Visits)
                .Skip((page - 1) * size)
                .Take(size)
                .OrderBy(x => x.FirstName)
                .ToListAsync();

            return users;
        }
    }
}
