using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeatherPresentation.Common;
using WeatherPresentation.Views;
using WeatherDomainModel.Service.Implementation;
using WeatherDomainModel.Service.Interfaces;
using WeatherPresentation.Presenters;

namespace WeatherWinFormsUI
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var controller = new ApplicationController(new LightInjectAdapder())
                .RegisterView<IMainView, MainForm>()
                .RegisterView<ICurrentWeatherView, CurrentWeatherForm>()
                .RegisterService<ICurrentWeatherService, CurrentWeatherService>()
                .RegisterInstance(new ApplicationContext());

            controller.Run<MainFormPresenter>();
        }
    }
}
