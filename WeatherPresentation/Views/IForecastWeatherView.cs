using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherPresentation.Views
{
    public interface IForecastWeatherView : ICurrentWeatherView
    {
        public void AddTimeItem(string TimeItem);
        public void ResetTimeList();
        event Action<int> SelectTime;
    }
}
