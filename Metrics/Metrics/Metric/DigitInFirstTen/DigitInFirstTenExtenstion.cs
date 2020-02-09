using Metrics.Metrics.Comparers.CheckHasDigit;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Metrics.Metrics.Metric.DigitInFirstTen
{
    public static class DigitInFirstTenExtenstion
    {
        public static IServiceCollection AddDigitInFirstTenMetric(this IServiceCollection services)
        {
            services.AddSingleton<IStringHasDigit, HasFirstTenLetterDigit>();
            services.AddSingleton<DigitInFirstTenCharactersMetric>();

            return services;
        }
    }
}
