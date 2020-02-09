using Metrics.MetricsHandlers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Metrics.Services
{
    public interface IMetricHandlers
    {
        ICollection<IMetric> GetMetricsHandelers();
    }
}
