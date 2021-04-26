using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cwk.TMW.Common.Abstractions
{
    public interface IMeasurementConvertible<T>
    {
        T ConvertFromMetricToImperial();
        T ConvertFromImperialToMetric();
    }
}
