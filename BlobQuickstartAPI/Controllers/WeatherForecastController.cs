using Microsoft.AspNetCore.Mvc;
using System.IO;

namespace BlobQuickstartAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static string blobconnectionstring = "DefaultEndpointsProtocol=https;AccountName=capegeblobstorage;AccountKey=HdLeGUZG28YHJEITidIK3I2MfDfH/ip+R53xGhKFD9QSAP8K0wqeK2eQf5GSsdD90fasXWPNHMlT+AStWNTMiw==;EndpointSuffix=core.windows.net";
        private static string containername = "democontainer";
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<WeatherForecast> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }

    }
       
       
}

