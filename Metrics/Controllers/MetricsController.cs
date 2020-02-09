using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Metrics.Models;
using Metrics.Services.Metrics;
using Metrics.ViewModel;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Metrics.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MetricsController : Controller
    {
        IMetricService _metricService;

        public MetricsController(IMetricService metricService)
        {
            _metricService = metricService;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<MetricModel>>> GetAllMetrics()
        {
            IEnumerable<MetricModel> metrics = await _metricService.GetMetricsAsync();
                return Ok(metrics);           
        }
        [HttpPost]
        public async Task<IActionResult> HandleMetrics(MetricTextViewModel metricText)
        {
            if (String.IsNullOrEmpty(metricText.dataString))
            {
                return BadRequest("No value provided");
            }


            await _metricService.CalculateMetricsAsync(metricText.dataString);

            return Ok();
        }
    }
}
