using Metrics.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Metrics.Services.Metrics
{
    public interface IMetricService
    {
        Task<IEnumerable<MetricModel>> GetMetricsAsync();
        Task CalculateMetricsAsync(string text);
    }
}
