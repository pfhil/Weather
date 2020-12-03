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
            View.GetWeather += () => OnGetWeatherAsync();
        }

        private async void OnGetWeatherAsync()
        {
            CurrentWeatherData Response;
            try
            {
                Response = await Task.Run(() => _service.GetCurrentWeatherDataByName(View.CityName, HttpClient));
            }
            catch (HttpRequestException ex)
            {
                View.ShowMessage(ex.Message);
                return;
            }
            var WeatherInfo = new CurrentWeatherInfo()
            {
                Temp = Response.Main.Temp.ToString(),
                Description = Response.Weather.FirstOrDefault().Description,
                Visibility = $"{Response.Visibility} метров",
                WindSpeed = $"{Response.Wind.Speed} м/с",
                WindDirection = Response.Wind.Direction.ToString(),
                CloudsPercent = $"{Response.Clouds.Percent}%",
                CountryCode = Response.Sys.CountryCode,
                Sunrise = TimeSpan.FromSeconds(Response.Sys.Sunrise).ToString(@"hh\:mm\:ss"),
                Sunset = TimeSpan.FromSeconds(Response.Sys.Sunset).ToString(@"hh\:mm\:ss")
            };
            View.SetWeatherInfo(WeatherInfo);
        }
    }
}
