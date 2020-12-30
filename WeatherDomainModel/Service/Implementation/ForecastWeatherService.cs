using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherDomainModel.JSONResponse;
using System.Net.Http;
using System.Net.Http.Json;
using System.IO;
using Newtonsoft.Json;
using WeatherDomainModel.Service.Interfaces;
using System.Configuration;
using System.Collections.Specialized;

namespace WeatherDomainModel.Service.Implementation
{
    public class ForecastWeatherService : BaseService, IForecastWeatherService
    {
        private string uri = $"http://api.openweathermap.org/data/2.5/forecast?&appid={AppId}";

        public Task<ForecastWeatherData> GetForecastWeatherDataByCityName(string CityName, HttpClient httpClient)
        {
            var _uri = uri
                .AddCityName(CityName)
                .UseUnits("metric")
                .UseLang("ru");
            return GetJsonHttpClientAsync<ForecastWeatherData>(_uri, httpClient);
        }
    }
}
