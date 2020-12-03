using System;
using WeatherPresentation.Common;

namespace WeatherPresentation.Views
{
    public interface IMainView : IView
    {
        event Action OpenCurrentWeather;
    }
}
