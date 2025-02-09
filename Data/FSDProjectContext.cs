using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using FSDProject.Domain;
using FSDProject.Configurations.Entities;

namespace FSDProject.Data
{
    public class FSDProjectContext : DbContext
    {
        public FSDProjectContext (DbContextOptions<FSDProjectContext> options)
            : base(options)
        {
        }

        public DbSet<FSDProject.Domain.Course> Course { get; set; } = default!;
        public DbSet<FSDProject.Domain.CourseDatabase> CourseDatabase { get; set; } = default!;
        public DbSet<FSDProject.Domain.RewardShop> RewardShop { get; set; } = default!;
        public DbSet<FSDProject.Domain.Score> Score { get; set; } = default!;
        public DbSet<FSDProject.Domain.StoreItem> StoreItem { get; set; } = default!;
        public DbSet<FSDProject.Domain.UserAcc> UserAcc { get; set; } = default!;
        public DbSet<FSDProject.Domain.UserProfile> UserProfile { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder Builder)
        {
            base.OnModelCreating(Builder);

            Builder.ApplyConfiguration(new CourseDatabaseSeed());
            Builder.ApplyConfiguration(new RewardShopSeed());
            Builder.ApplyConfiguration(new StoreItemSeed());
            Builder.ApplyConfiguration(new CourseSeed());
            
        }
    }
}
