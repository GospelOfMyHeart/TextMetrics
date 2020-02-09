using Metrics.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Metrics.Metrics.Metric
{
    public class BaseMetric
    {
        protected readonly string metricName;
        protected readonly string metricTitle;

        public BaseMetric(string metricName, string metricTitle)
        {
            this.metricName = metricName;
            this.metricTitle = metricTitle;
        }
        protected MetricModel GetCurrentMetricModel()
        {
            MetricModel returnModel = new MetricModel();

            returnModel.MetricName = metricName;
            returnModel.MetricTitle = metricTitle;
            return returnModel;
        }
    }
}
