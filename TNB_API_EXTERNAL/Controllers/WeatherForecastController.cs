using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TNB_API_EXTERNAL;

namespace TNB_API_EXTERNAL.Controllers
{
    [ApiController]
    [Route("health")]
    public class WeatherForecastController : ControllerBase
    {

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public string Get()
        {
            _logger.LogInformation("service health check");
            Console.WriteLine("performing health check");
            return "service is ok";
        }
    }
}
