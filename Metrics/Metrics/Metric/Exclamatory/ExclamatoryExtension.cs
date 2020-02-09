using Metrics.Metrics.Comparers.ExclamatorySentenceComparer;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Metrics.Metrics.Metric.Exclamatory
{
    public static class ExclamatoryExtension
    {
        public static IServiceCollection AddExclamatoryMetric(this IServiceCollection services)
        {
            services.AddSingleton<IExclamatorySentenceComparer, RussianExclamatorySentenceComparer>();
            services.AddSingleton<ExclamatorySentenceMetric>();

            return services;
        }
    }
}
