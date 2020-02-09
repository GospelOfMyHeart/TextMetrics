using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Metrics.MetricsHandlers;
using Metrics.Models;
using Metrics.Services.Metrics.MetricDataStorage;

namespace Metrics.Services.Metrics
{
    public class MetricService : IMetricService
    {
        IMetricDataStorage _metricsData;
        IMetricHandlers _metricHandlers;

        public MetricService(IMetricDataStorage metricsData, IMetricHandlers metricHandlers)
        {
            _metricsData = metricsData;
            _metricHandlers = metricHandlers;
        }

        async public Task CalculateMetricsAsync(string text)
        {
            IEnumerable<IMetric> metricsHandlers = _metricHandlers.GetMetricsHandelers();
            foreach (var handler in metricsHandlers)
            {
                await _metricsData.UpdateOrAddMetricAsync(handler.HandleMetric(text));
            }
        }

        async public Task<IEnumerable<MetricModel>> GetMetricsAsync()
        {
            IEnumerable<MetricModel> models = await _metricsData.GetAllMetricsAsync();
            return models;
        }
    }
}
