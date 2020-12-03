using System;
using WeatherPresentation.Common;

namespace WeatherPresentation.Views
{
    public interface ICurrentWeatherView : IView
    {
        public string CityName { get; }
        public void SetWeatherInfo(CurrentWeatherInfo weatherInfo);
        event Action GetWeather;

    }
}
