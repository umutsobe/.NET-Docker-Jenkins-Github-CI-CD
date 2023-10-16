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
        private readonly IConfiguration _configuration;

        public WeatherForecastController(
            IHttpContextAccessor httpContextAccessor,
            IConfiguration configuration
        )
        {
            _httpContextAccessor = httpContextAccessor;
            _configuration = configuration;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public IActionResult Get()
        {
            var response = _configuration["testEnvironment"];

            return Ok(response);
        }
    }
}
