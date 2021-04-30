using Cwk.TMW.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cwk.TMW.Infrastructure.Configuration
{
    public class AthleteConfiguration : IEntityTypeConfiguration<Athlete>
    {
        public void Configure(EntityTypeBuilder<Athlete> builder)
        {
            builder.OwnsOne(a => a.Location);
            builder.OwnsOne(a => a.ProfileSettings);
            builder.OwnsOne(a => a.Height);
            builder.OwnsOne(a => a.Weight);
        }
    }
}
