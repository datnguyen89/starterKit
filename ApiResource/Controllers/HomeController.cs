using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiResource.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HomeController : Controller
    {
        [HttpGet]
        [Route("/just-say-hello")]
        [ApiExplorerSettings(GroupName = "v2")]
        public WeatherForecast JustSayHello()
        {
            return new WeatherForecast();
        }
    }
}
