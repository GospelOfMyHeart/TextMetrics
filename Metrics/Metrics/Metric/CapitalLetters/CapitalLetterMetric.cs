using Metrics.Metrics.Comparers.CapitalLetterComparer;
using Metrics.MetricsHandlers;
using Metrics.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Metrics.Metrics.Metric.CapitalLetters
{
    public class CapitalLetterMetric : BaseMetric, IMetric
    {
        ICapitalLetterComparer _comparer;

        public CapitalLetterMetric(ICapitalLetterComparer comparer) : base("Capital russian letter", "Количество заглавных букв")
        {
            _comparer = comparer;
        }

        public MetricModel HandleMetric(string text)
        {
            int capLettersCount = _comparer.CountCapitalLettersMatches(text);

            MetricModel returnModel = GetCurrentMetricModel();
            returnModel.Value = capLettersCount.ToString();

            return returnModel;
        }
    }
}
