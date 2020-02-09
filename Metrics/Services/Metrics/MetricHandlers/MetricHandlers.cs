using Metrics.Metrics.Metric;
using Metrics.Metrics.Metric.CapitalLetters;
using Metrics.Metrics.Metric.DigitInFirstTen;
using Metrics.MetricsHandlers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Metrics.Services
{
    public class MetricHandlers : IMetricHandlers
    {
        ICollection<IMetric> _metricsHandlers = new List<IMetric>();

        public MetricHandlers(
            ExclamatorySentenceMetric exclamatorySentence,
            CapitalLetterMetric capsLetters,
            DigitInFirstTenCharactersMetric digitInFirstTenCharacters
            )
        {
            _metricsHandlers.Add(exclamatorySentence);
            _metricsHandlers.Add(capsLetters);
            _metricsHandlers.Add(digitInFirstTenCharacters);
        }

        public ICollection<IMetric> GetMetricsHandelers()
        {
            return _metricsHandlers;
        }
    }
}
