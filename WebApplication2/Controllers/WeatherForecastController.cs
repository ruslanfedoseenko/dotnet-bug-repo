using Microsoft.AspNetCore.Mvc;
using WebApplication2.Services;

namespace WebApplication2.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    private readonly ILogger<WeatherForecastController> _logger;
    private readonly ISomeService _someService;

    public WeatherForecastController(ILogger<WeatherForecastController> logger, ISomeService someService)
    {
        _logger = logger;
        _someService = someService;
    }

    [HttpPost(Name = "SetData")]
    public IActionResult Post(WeatherForecast weatherForecast)
    {
        
        _someService.DoSmth();
        return Ok();
    }
}