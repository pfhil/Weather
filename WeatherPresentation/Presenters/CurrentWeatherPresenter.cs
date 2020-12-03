using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherPresentation.Common;
using WeatherPresentation.Views;
using WeatherDomainModel.Service.Interfaces;
using WeatherDomainModel.Service.Implementation;
using WeatherDomainModel.JSONResponse;
using System.Net.Http;

namespace WeatherPresentation.Presenters
{
    public class CurrentWeatherPresenter : BasePresener<ICurrentWeatherView>
    {
        private readonly ICurrentWeatherService _service;
        private SingletonHttpClient HttpClient = SingletonHttpClient.GetInstance();

        public CurrentWeatherPresenter(IApplicationController controller, ICurrentWeatherView view, ICurrentWeatherService service) 
            : base(controller, view)
        {

            _service = service;
            View.GetWeather += () => OnGetWeather();
        }

        private void OnGetWeather()
        {
            var Response = Task.Run(() => _service.GetCurrentWeatherDataByName(View.CityName, HttpClient));
            try
            {
                Response.Wait();
            }
            catch (HttpRequestException ex)
            {
                View.ShowMessage(ex.Message);
                return;
            }
            var WeatherInfo = new CurrentWeatherInfo()
            {
                Temp = Response.Result.Main.Temp.ToString(),
                Description = Response.Result.Weather.FirstOrDefault().Description,
                Visibility = $"{Response.Result.Visibility} метров",
                WindSpeed = $"{Response.Result.Wind.Speed} м/с",
                WindDirection = Response.Result.Wind.Direction.ToString(),
                CloudsPercent = $"{Response.Result.Clouds.Percent}%",
                CountryCode = Response.Result.Sys.CountryCode,
                Sunrise = TimeSpan.FromSeconds(Response.Result.Sys.Sunrise).ToString(@"hh\:mm\:ss"),
                Sunset = TimeSpan.FromSeconds(Response.Result.Sys.Sunset).ToString(@"hh\:mm\:ss")
            };
            View.SetWeatherInfo(WeatherInfo);
        }
    }
}
