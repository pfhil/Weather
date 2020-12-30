using System;
using WeatherPresentation.Common;

namespace WeatherPresentation.Views
{
    public interface ICurrentWeatherView : IView
    {
        public string CityName { get; }
        public void SetWeatherInfo(WeatherInfo weatherInfo);
        event Action GetWeather;

    }
}
