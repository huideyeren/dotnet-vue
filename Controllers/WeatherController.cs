using System.Linq;
using Microsoft.AspNetCore.Mvc;
using dotnet_vue.Providers;

namespace dotnet_vue.Controllers
{
    /// <summary>
    /// Weather controller.
    /// </summary>
    [Route("api/[controller]")]
    public class WeatherController : Controller
    {
        /// <summary>
        /// The weather provider.
        /// </summary>
        private readonly IWeatherProvider weatherProvider;

        /// <summary>
        /// Initializes a new instance of the <see cref="T:dotnet_vue.Controllers.WeatherController"/> class.
        /// </summary>
        /// <param name="weatherProvider">Weather provider.</param>
        public WeatherController(IWeatherProvider weatherProvider)
        {
            this.weatherProvider = weatherProvider;
        }

        /// <summary>
        /// Forecasts the specified from and to.
        /// </summary>
        /// <returns>The forecasts.</returns>
        /// <param name="from">From.</param>
        /// <param name="to">To.</param>
        [HttpGet("[action]")]
        public IActionResult Forecasts([FromQuery(Name = "from")] int from = 0, [FromQuery(Name = "to")] int to = 4)
        {
            //System.Threading.Thread.Sleep(500); // Fake latency
            var quantity = to - from;

            // We should also avoid going too far in the list.
            if (quantity <= 0)
            {
                return BadRequest("You cannot have the 'to' parameter higher than 'from' parameter.");
            }

            if (from < 0)
            {
                return BadRequest("You cannot go in the negative with the 'from' parameter");
            }

            var allForecasts = weatherProvider.GetForecasts();
            var result = new
            {
                Total = allForecasts.Count,
                Forecasts = allForecasts.Skip(from).Take(quantity).ToArray()
            };

            return Ok(result);
        }
    }
}
