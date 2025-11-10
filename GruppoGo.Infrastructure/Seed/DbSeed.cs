using GruppoGo.Domain.Entities;
using GruppoGo.Domain.Enums;
using GruppoGo.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GruppoGo.Infrastructure.Seed
{
    public class DbSeed(AppDbContext _context)
    {
        public async Task SeedAsync()
        {
            // -------------------
            // Users
            // -------------------
            if (!_context.Users.Any())
            {
                var users = new List<User>
                {
                    new() {
                        Id = Guid.NewGuid(),
                        FirstName = "Andrzej",
                        LastName = "Gniłka",
                        Email = "gnilka@wp.pl",
                        CreatedAt = DateTime.UtcNow,
                        UpdatedAt = DateTime.UtcNow,
                        PasswordHash = "hashed_password_1",
                        AccountType = AccountTypeEnum.Member
                    },
                    new () {
                        Id = Guid.NewGuid(),
                        FirstName = "Krzysztof",
                        LastName = "Piątek",
                        Email = "piopio@wp.pl",
                        CreatedAt = DateTime.UtcNow,
                        UpdatedAt = DateTime.UtcNow,
                        PasswordHash = "hashed_password_2",
                        AccountType = AccountTypeEnum.Member
                    },
                    new () {
                        Id = Guid.NewGuid(),
                        FirstName = "Karol",
                        LastName = "Kowalski",
                        Email = "karol@wp.pl",
                        CreatedAt = DateTime.UtcNow,
                        UpdatedAt = DateTime.UtcNow,
                        PasswordHash = "hashed_password_3",
                        AccountType = AccountTypeEnum.Leader
                    }
                };

                _context.Users.AddRange(users);
                await _context.SaveChangesAsync();
            }

            // -------------------
            // Groups
            // -------------------
            if (!_context.Groups.Any())
            {
                var leader = _context.Users.First(x => x.AccountType == AccountTypeEnum.Leader);
                var members = _context.Users
                                    .Where(x => x.AccountType == AccountTypeEnum.Member)
                                    .ToList();

                var group = new Group
                {
                    Id = Guid.NewGuid(),
                    Name = "Exo",
                    Description = "Group for exo dancers",
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,
                    Leader = leader,
                    Members = members
                };

                _context.Groups.Add(group);
                await _context.SaveChangesAsync();

                // -------------------
                // Schedules
                // -------------------
                var schedule = new Schedule
                {
                    Id = Guid.NewGuid(),
                    Group = group,
                    StartTime = DateTime.UtcNow.AddDays(1).AddHours(9),
                    EndTime = DateTime.UtcNow.AddDays(1).AddHours(10),
                    Visits = []
                };

                _context.Schedules.Add(schedule);
                await _context.SaveChangesAsync();

                // -------------------
                // Passes
                // -------------------
                var passes = members.Select(m => new Pass
                {
                    Id = Guid.NewGuid(),
                    User = m,
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,
                    Type = PassTypeEnum.Standard,
                    StartAt = DateTime.UtcNow,
                    EndAt = DateTime.UtcNow.AddMonths(1),
                    RemainingVisits = 10,
                    Visits = []
                }).ToList();

                _context.Passes.AddRange(passes);
                await _context.SaveChangesAsync();

                // -------------------
                // Visits
                // -------------------
                var visits = members.Select((m, idx) => new Visit
                {
                    Id = Guid.NewGuid(),
                    User = m,
                    Schedule = schedule,
                    Pass = passes[idx],
                    VisitDate = schedule.StartTime,
                    WasPresent = false
                }).ToList();

                for (int i = 0; i < passes.Count; i++)
                {
                    passes[i].Visits.Add(visits[i]);
                    schedule.Visits.Add(visits[i]);
                }

                _context.Visits.AddRange(visits);
                await _context.SaveChangesAsync();
            }
        }
    }
}
