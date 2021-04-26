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
        
        string TimeZone { get; init; }
        MeasurementSystem PreferredMeasurementSystem { get; init; }

    }
}
