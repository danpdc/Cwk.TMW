using Cwk.TMW.Common.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cwk.TMW.Core.Models
{
    public record ProfileSettings
    {
        public ProfileSettings(string timeZone, MeasurementSystem system)
        {
            TimeZone = timeZone;
            PreferredMeasurementSystem = system;
        }

        private ProfileSettings() { }
        
        public string TimeZone { get; init; }
        public MeasurementSystem PreferredMeasurementSystem { get; init; }

    }
}
