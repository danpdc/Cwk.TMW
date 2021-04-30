using Cwk.TMW.Common.Abstractions;
using Cwk.TMW.Common.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cwk.TMW.Common.Types
{
    public record Distance : IMeasurementConvertible<Distance>
    {
        public Distance(double value, MeasurementSystem system)
        {
            Value = value;
            MeasurementSystem = system;
        }

        private Distance() { }

        public double Value { get; init; }
        public MeasurementSystem MeasurementSystem { get; init; }

        public Distance ConvertFromImperialToMetric()
        {
            if (MeasurementSystem == MeasurementSystem.Metric)
                return this;

            return new Distance(Value * 1.61, MeasurementSystem.Metric);
        }

        public Distance ConvertFromMetricToImperial()
        {
            if (MeasurementSystem == MeasurementSystem.Imperial)
                return this;

            return new Distance(Value * 0.62, MeasurementSystem.Imperial);
        }
    }
}
