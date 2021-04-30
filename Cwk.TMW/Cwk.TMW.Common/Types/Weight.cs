using Cwk.TMW.Common.Abstractions;
using Cwk.TMW.Common.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cwk.TMW.Common.Types
{
    public record Weight : IMeasurementConvertible<Weight>
    {
        public Weight(double value, MeasurementSystem system)
        {
            Value = value;
            MeasurementSystem = system;
        }

        private Weight() { }
        
        public double Value { get; init; }
        public MeasurementSystem MeasurementSystem { get; init; }

        public Weight ConvertFromMetricToImperial()
        {
            if (MeasurementSystem == MeasurementSystem.Imperial)
                return this;

            return new Weight(Value * 2.2046, MeasurementSystem.Imperial);
        }

        public Weight ConvertFromImperialToMetric()
        {
            if (MeasurementSystem == MeasurementSystem.Metric)
                return this;

            return new Weight(Value * 0.454, MeasurementSystem.Metric);
        }
    }
}
