using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherPresentation.Common;
using WeatherPresentation.Views;

namespace WeatherPresentation.Presenters
{
    public class MainFormPresenter : BasePresener<IMainView>
    {
        public MainFormPresenter(IApplicationController controller, IMainView view) : base(controller, view)
        {
            View.OpenCurrentWeather += () => { controller.Run<CurrentWeatherPresenter>(); };
        }
    }
}
