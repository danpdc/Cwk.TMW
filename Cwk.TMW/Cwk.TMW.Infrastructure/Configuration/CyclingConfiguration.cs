using Cwk.TMW.Core.Models.Workouts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cwk.TMW.Infrastructure.Configuration
{
    public class CyclingConfiguration : IEntityTypeConfiguration<Cycling>
    {
        public void Configure(EntityTypeBuilder<Cycling> builder)
        {
            builder.OwnsOne(c => c.AverageSpeed);
            builder.OwnsOne(c => c.Distance);
            builder.OwnsOne(c => c.ElevationGain);
            builder.OwnsOne(c => c.ElevationLoss);
            builder.OwnsOne(c => c.MaxSpeed);
            builder.OwnsOne(c => c.TotalElevation);
            builder.OwnsOne(c => c.TotalElevation);
        }
    }
}
