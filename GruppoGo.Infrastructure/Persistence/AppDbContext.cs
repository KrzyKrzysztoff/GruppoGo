using GruppoGo.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GruppoGo.Infrastructure.Persistence
{
    public class AppDbContext(DbContextOptions options) : DbContext(options)
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<Visit> Visits { get; set; }
        public DbSet<Schedule> Schedules { get; set; }
        public DbSet<Pass> Passes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<User>()
                .HasMany(g => g.Groups)
                .WithMany(u => u.Members)
                .UsingEntity<Dictionary<string, object>>(
                    "UsersGroups",
                    j => j.HasOne<Group>()
                          .WithMany()
                          .HasForeignKey("GroupId")
                          .OnDelete(DeleteBehavior.Restrict),
                    j => j.HasOne<User>()
                          .WithMany()
                          .HasForeignKey("UserId")
                          .OnDelete(DeleteBehavior.Restrict)
                );

            modelBuilder.Entity<User>()
                .HasMany(v => v.Visits)
                .WithOne(u => u.User)
                .HasForeignKey("UserId")
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Group>()
                 .HasOne(g => g.Leader)
                 .WithMany(u => u.LeadedGroups)
                 .HasForeignKey("LeaderId")
                 .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Schedule>()
                .HasOne(s => s.Group)
                .WithMany(x=>x.Schedules)
                .HasForeignKey("GroupId")
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Schedule>()
                .HasMany(s => s.Visits)
                .WithOne(v => v.Schedule)
                .HasForeignKey("ScheduleId")
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Pass>()
                 .HasOne(p => p.User)
                 .WithMany(u => u.Passes)
                 .HasForeignKey("UserId")
                 .OnDelete(DeleteBehavior.Restrict);


            modelBuilder.Entity<Visit>()
                .HasOne(v => v.Pass)
                .WithMany(p => p.Visits)
                .HasForeignKey("PassId")
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
