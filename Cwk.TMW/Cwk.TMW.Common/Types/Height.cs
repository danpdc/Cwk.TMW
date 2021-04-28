using Cwk.TMW.Common.Abstractions;
using Cwk.TMW.Common.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cwk.TMW.Common.Types
{
    public record Height : IMeasurementConvertible<Height>
    {
        public Height(double value, MeasurementSystem system)
        {
            Value = value;
            MeasurementSystem = system;
        }

        private Height() { }

        public int Id { get; set; }
        public double Value { get; init; }
        public MeasurementSystem MeasurementSystem { get; init; }

        public Height ConvertFromMetricToImperial()
        {
            if (MeasurementSystem == MeasurementSystem.Imperial)
                return this;

            var valueInMeters = Value * 100;
            return new Height(valueInMeters * 3.28, MeasurementSystem.Imperial);
        }

        public Height ConvertFromImperialToMetric()
        {
            if (MeasurementSystem == MeasurementSystem.Metric)
                return this;

            var valueInCentimeters = (Value * 0.30) / 100;
            return new Height(valueInCentimeters, MeasurementSystem.Metric);
        }

    }
}
