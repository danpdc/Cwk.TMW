using Cwk.TMW.Common.Types;
using Cwk.TMW.Core.Abstractions;
using Cwk.TMW.Core.Abstractions.WorkouttAbstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cwk.TMW.Core.Models.Workouts
{
    public class Walking : IWorkout, IDistanceWorkout
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTimeOffset DateCreated { get; set; }
        public DateTimeOffset DateUpdated { get; set; }
        public int Duration { get; set; }
        public Distance Distance { get; set ; }
        public int Steps { get; set; }
        public int AthleteId { get; set; }
        public Athlete Athlete { get; set; }
    }
}
