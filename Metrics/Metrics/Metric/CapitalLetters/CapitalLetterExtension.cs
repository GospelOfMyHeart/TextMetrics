using Metrics.Metrics.Comparers.CapitalLetterComparer;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Metrics.Metrics.Metric.CapitalLetters
{
    public static class CapitalLetterExtension
    {
        public static IServiceCollection AddCapitalLetterMetric(this IServiceCollection services)
        {
            services.AddSingleton<ICapitalLetterComparer, RussianCapitalLetterMatcher>();
            services.AddSingleton<CapitalLetterMetric>();

            return services;
        }
    }
}
