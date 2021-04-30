using Cwk.TMW.Common.Abstractions;
using Cwk.TMW.Common.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cwk.TMW.Common.Types
{
    public class Speed : IMeasurementConvertible<Speed>
    {
        public Speed(double value, MeasurementSystem system)
        {
            Value = value;
            MeasurementSystem = system;
        }

        private Speed() { }
        public double Value { get; set; }
        public MeasurementSystem MeasurementSystem { get; set; }

        public Speed ConvertFromImperialToMetric()
        {
            if (MeasurementSystem == MeasurementSystem.Metric)
                return this;

            return new Speed(Value * 1.609344, MeasurementSystem.Metric);
        }

        public Speed ConvertFromMetricToImperial()
        {
            if (MeasurementSystem == MeasurementSystem.Imperial)
                return this;

            return new Speed(Value * 0.6213711922, MeasurementSystem.Imperial);
        }
    }
}
