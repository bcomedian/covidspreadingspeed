using CovidSpreadingSpeed.WebService.Models;
using Microsoft.AspNetCore.Mvc;
using System.Threading;

namespace CovidSpreadingSpeed.WebService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SpreadingSpeedController : ControllerBase
    {
        [HttpGet]
        public string Get()
        {
            return "not implemented";
        }
    }
}
