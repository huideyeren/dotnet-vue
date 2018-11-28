using System;
using System.Collections.Generic;
using System.Linq;
using dotnet_vue.Models;

namespace dotnet_vue.Providers
{
    /// <summary>
    /// Weather provider fake.
    /// </summary>
    public class WeatherProviderFake : IWeatherProvider
    {
        /// <summary>
        /// The summaries.
        /// </summary>
        private readonly string[] summaries = {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        /// <summary>
        /// Gets or sets the weather forecasts.
        /// </summary>
        /// <value>The weather forecasts.</value>
        private List<WeatherForecast> WeatherForecasts { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="T:dotnet_vue.Providers.WeatherProviderFake"/> class.
        /// </summary>
        public WeatherProviderFake()
        {
            Initialize(50);
        }

        /// <summary>
        /// Initialize the specified quantity.
        /// </summary>
        /// <param name="quantity">Quantity.</param>
        private void Initialize(int quantity)
        {
            var rng = new Random();
            WeatherForecasts = Enumerable.Range(1, quantity).Select(index => new WeatherForecast
            {
                DateFormatted = DateTime.Now.AddDays(index).ToString("d"),
                TemperatureC = rng.Next(-20, 55),
                Summary = summaries[rng.Next(summaries.Length)]
            }).ToList();
        }

        /// <summary>
        /// Gets the forecasts.
        /// </summary>
        /// <returns>The forecasts.</returns>
        public List<WeatherForecast> GetForecasts()
        {
            return WeatherForecasts;
        }
    }
}
