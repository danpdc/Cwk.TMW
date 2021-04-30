using Cwk.TMW.Core.Models;
using Cwk.TMW.Core.Models.Workouts;
using Cwk.TMW.Infrastructure.Configuration;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cwk.TMW.Infrastructure.Data
{
    public class TmwDbContext : IdentityDbContext
    {
        public TmwDbContext(DbContextOptions options) : base(options) { }

        public new DbSet<User> Users { get; set; }
        public DbSet<Athlete> Athletes { get; set; }
        public DbSet<Cycling> CyclingWorkouts { get; set; }
        public DbSet<Walking> WalkingWorkouts { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new AthleteConfiguration());
            builder.ApplyConfiguration(new CyclingConfiguration());
            builder.ApplyConfiguration(new UserConfiguration());
            builder.ApplyConfiguration(new WalkingConfiguration());
            base.OnModelCreating(builder);
        }
    }
}
