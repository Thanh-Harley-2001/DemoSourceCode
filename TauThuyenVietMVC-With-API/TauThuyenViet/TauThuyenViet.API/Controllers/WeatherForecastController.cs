using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TauThuyenViet.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        [HttpGet]
        public object Get()
        {
            var rng = new Random();
            var TemperatureC = rng.Next(1, 9);
            return TemperatureC;
        }
    }
}
