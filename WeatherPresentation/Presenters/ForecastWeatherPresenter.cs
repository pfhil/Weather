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
    class ForecastWeatherPresenter : BasePresener<IForecastWeatherView>
    {
        private readonly IForecastWeatherService _service;
        private SingletonHttpClient HttpClient = SingletonHttpClient.GetInstance();
        private ForecastWeatherData ForecastWeatherResponse;

        public ForecastWeatherPresenter(IApplicationController controller, IForecastWeatherView view, IForecastWeatherService service)
            : base(controller, view)
        {

            _service = service;
            View.GetWeather += () => OnGetWeatherAsync();
            View.SelectTime += Index => OnSelectTime(Index);
        }

        private void OnSelectTime(int Index)
        {
            var weatherInfo = new WeatherInfo()
            {
                Temp = ForecastWeatherResponse.List[Index].Main.Temp.ToString(),
                Description = ForecastWeatherResponse.List[Index].Weather.FirstOrDefault().Description,
                Visibility = $"{ForecastWeatherResponse.List[Index].Visibility} метров",
                WindSpeed = $"{ForecastWeatherResponse.List[Index].Wind.Speed} м/с",
                WindDirection = ForecastWeatherResponse.List[Index].Wind.Direction.ToString(),
                CloudsPercent = $"{ForecastWeatherResponse.List[Index].Clouds.Percent}%",
                CountryCode = ForecastWeatherResponse.Сity.Country,
                Sunrise = TimeSpan.FromSeconds(ForecastWeatherResponse.Сity.Sunrise).ToString(@"hh\:mm\:ss"),
                Sunset = TimeSpan.FromSeconds(ForecastWeatherResponse.Сity.Sunset).ToString(@"hh\:mm\:ss")
            };
            View.SetWeatherInfo(weatherInfo);
        }

        private async void OnGetWeatherAsync()
        {
            View.ResetTimeList();
            try
            {
                ForecastWeatherResponse = await Task.Run(() => _service.GetForecastWeatherDataByCityName(View.CityName, HttpClient));
            }
            catch (HttpRequestException ex)
            {
                View.ShowMessage(ex.Message);
                return;
            }

            foreach (var TimeItem in ForecastWeatherResponse.List)
            {
                View.AddTimeItem(TimeItem.DateTimetxt);
            }
        }
    }
}
