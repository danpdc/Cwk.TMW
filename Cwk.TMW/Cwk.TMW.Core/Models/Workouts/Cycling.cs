using Cwk.TMW.Common.Types;
using Cwk.TMW.Core.Abstractions;
using Cwk.TMW.Core.Abstractions.WorkouttAbstractions;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cwk.TMW.Core.Models.Workouts
{
    public class Cycling : IWorkout, IDistanceWorkout, IElevationWorkout, ISpeedWorkout
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTimeOffset DateCreated { get; set; }
        public DateTimeOffset DateUpdated { get; set; }
        public Distance Distance { get; set; }
        public int Duration { get; set; } 
        public Speed AverageSpeed { get; set; }
        public Speed MaxSpeed { get; set; }
        public Height ElevationGain { get; set; }
        public Height ElevationLoss { get; set; }
        public int AthleteId { get; set; }
        public Athlete Athlete { get; set; }

        [NotMapped]
        public Height TotalElevation { get { return GetTotalElevation(); } }

        private Height GetTotalElevation()
        {
            return new Height(ElevationGain.Value + ElevationLoss.Value, 
                ElevationGain.MeasurementSystem);
        }
    }
}
