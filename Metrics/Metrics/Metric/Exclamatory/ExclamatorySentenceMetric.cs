using Metrics.Metrics.Comparers.ExclamatorySentenceComparer;
using Metrics.MetricsHandlers;
using Metrics.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Metrics.Metrics.Metric
{
    public class ExclamatorySentenceMetric:BaseMetric, IMetric
    {

        IExclamatorySentenceComparer _comparer;

        public ExclamatorySentenceMetric(IExclamatorySentenceComparer comparer) : base("Exclamatory Russian", "Количеств восклицательных предложений в тексте")
        {
            _comparer = comparer;
        }

        public MetricModel HandleMetric(string text)
        {
            int matchesCount = _comparer.CountExclamatorySentenceMatches(text);


            MetricModel returnModel = GetCurrentMetricModel();
            returnModel.Value = matchesCount.ToString();

            return returnModel;
        }
    }
}
