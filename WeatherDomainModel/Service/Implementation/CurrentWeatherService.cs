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
using System.Threading;

namespace WeatherDomainModel.Service.Implementation
{
    public class CurrentWeatherService : BaseService, ICurrentWeatherService
    {
        private string uri = $"http://api.openweathermap.org/data/2.5/weather?&appid={AppId}";
        public Task<CurrentWeatherData> GetCurrentWeatherDataByCityName(string CityName, HttpClient httpClient)
        {
            var _uri = uri
                .AddCityName(CityName)
                .UseUnits("metric")
                .UseLang("ru");
            return GetJsonHttpClientAsync<CurrentWeatherData>(_uri, httpClient);
        }
    }
}
