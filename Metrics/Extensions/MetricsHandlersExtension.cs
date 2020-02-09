using Metrics.Metrics.Metric;
using Metrics.Metrics.Metric.CapitalLetters;
using Metrics.Metrics.Metric.DigitInFirstTen;
using Metrics.Metrics.Metric.Exclamatory;
using Metrics.Services;
using Metrics.Services.Metrics;
using Metrics.Services.Metrics.MetricDataStorage;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Metrics.Extensions
{

    public static class MetricsHandlersExtension
    {
        public static IServiceCollection AddMetricsHandlers(this IServiceCollection services)
        {
            services.AddSingleton<ExclamatorySentenceMetric>();



            services.AddSingleton<IMetricHandlers,MetricHandlers>();
            services.AddSingleton<IMetricDataStorage, LocalMetricDataStorage>();
            services.AddSingleton<IMetricService, MetricService>();

            services.AddExclamatoryMetric();
            services.AddCapitalLetterMetric();
            services.AddDigitInFirstTenMetric();

            return services;
        }
    }
}
