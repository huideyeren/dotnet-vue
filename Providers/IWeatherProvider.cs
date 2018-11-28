using System.Collections.Generic;
using dotnet_vue.Models;

namespace dotnet_vue.Providers
{
    /// <summary>
    /// Weather provider.
    /// </summary>
    public interface IWeatherProvider
    {
        List<WeatherForecast> GetForecasts();
    }
}
