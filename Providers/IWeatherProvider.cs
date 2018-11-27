using System.Collections.Generic;
using dotnet_vue.Models;

namespace dotnet_vue.Providers
{
    public interface IWeatherProvider
    {
        List<WeatherForecast> GetForecasts();
    }
}
