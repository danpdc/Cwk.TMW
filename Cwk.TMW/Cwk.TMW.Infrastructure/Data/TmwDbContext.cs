using Cwk.TMW.Core.Models;
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
    }
}
