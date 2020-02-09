using Metrics.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Metrics.Services.Metrics.MetricDataStorage
{
    public interface IMetricDataStorage
    {
        Task<IEnumerable<MetricModel>> GetAllMetricsAsync();
        Task<MetricModel> UpdateOrAddMetricAsync(MetricModel model);
        Task DeleteAllMetricsAsync();

        
    }
}
