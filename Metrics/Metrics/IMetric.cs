using Metrics.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Metrics.MetricsHandlers
{
    public interface IMetric
    {
        MetricModel HandleMetric(string text);
    }
}
