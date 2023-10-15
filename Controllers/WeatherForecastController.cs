using Microsoft.AspNetCore.Mvc;

namespace TestApi_CI_CD.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing",
            "Bracing",
            "Chilly",
            "Cool",
            "Mild",
            "Warm",
            "Balmy",
            "Hot",
            "Sweltering",
            "Scorching"
        };

        private readonly IHttpContextAccessor _httpContextAccessor;

        public WeatherForecastController(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public IActionResult Get()
        {
            var response = _httpContextAccessor.HttpContext.Connection.RemoteIpAddress.ToString();

            return Ok(response);
        }
    }
}
