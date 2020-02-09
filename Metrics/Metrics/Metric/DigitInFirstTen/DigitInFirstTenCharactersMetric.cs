using Metrics.Metrics.Comparers.CheckHasDigit;
using Metrics.MetricsHandlers;
using Metrics.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Metrics.Metrics.Metric.DigitInFirstTen
{
    public class DigitInFirstTenCharactersMetric: BaseMetric,IMetric
    {
        IStringHasDigit _firstTenHasDigit;

        public DigitInFirstTenCharactersMetric(IStringHasDigit firstTenHasDigit) : base("DigitInFirstTenCharacters", "Наличие цифры в одном из первых десяти символов")
        {
            _firstTenHasDigit = firstTenHasDigit;
        }

        public MetricModel HandleMetric(string text)
        {
            bool isHas = _firstTenHasDigit.StringHasDigit(text);

            MetricModel returnModel = GetCurrentMetricModel();

            returnModel.Value = isHas == true ?  "Да" : "Нет";
       
            return returnModel;
        }
    }
}
