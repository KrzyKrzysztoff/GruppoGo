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
        public IQueryable<User> GetAll(int page, int size)
        {
            var users = _dbContext
                .Users
                .Include(x => x.Groups)
                .Include(x => x.Passes)
                .Include(x => x.Visits);

            return users;
        }

        public async Task<User> GetById(Guid Id)
        {
            var users = _dbContext.Users.AsEnumerable();
            ICollection<User> users3 = _dbContext.Users.ToList();
            var users2 = _dbContext.Users.ToList();

            users3.Add()
           users.Add

            foreach (var item in users)
            {
                item.Id = "asd";
            }
            var user = await _dbContext.
                Users.
                FirstOrDefaultAsync(x => x.Id == Id);


        }
    }
}
