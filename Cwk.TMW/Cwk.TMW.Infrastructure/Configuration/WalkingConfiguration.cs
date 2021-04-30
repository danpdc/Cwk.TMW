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
    public class WalkingConfiguration : IEntityTypeConfiguration<Walking>
    {
        public void Configure(EntityTypeBuilder<Walking> builder)
        {
            builder.OwnsOne(w => w.Distance);
        }
    }
}
