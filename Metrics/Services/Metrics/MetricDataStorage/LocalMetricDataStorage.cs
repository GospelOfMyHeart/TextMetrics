using Metrics.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Metrics.Services.Metrics.MetricDataStorage
{
    public class LocalMetricDataStorage:IMetricDataStorage
    {
        List<MetricModel> models = new List<MetricModel>();

        async public Task<IEnumerable<MetricModel>> GetAllMetricsAsync()
        {
            return await Task.Run(() => models);
        }
        public async Task<MetricModel> UpdateOrAddMetricAsync(MetricModel model)
        {
            int metricToUpdateIndex = models.FindIndex((m) => m.MetricName == model.MetricName);
            await Task.Run(() =>
            {
                if (metricToUpdateIndex == -1)
                {
                    AddMetric(model);
                }
                else
                {
                    UpdateMetric(metricToUpdateIndex, model);
                }
            });
            return model;
        }
        public async Task DeleteAllMetricsAsync()
        {
            await Task.Run(() => models.Clear());
        }
        MetricModel AddMetric(MetricModel model)
        {
            models.Add(model);
            return model;            
        }
        MetricModel UpdateMetric(int index, MetricModel model)
        {
            models[index] = model;
            return model;
        }

  
    }
}
