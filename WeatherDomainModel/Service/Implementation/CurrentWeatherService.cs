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
    public class CurrentWeatherService : BaseService, ICurrentWeatherService
    {
        public async Task<CurrentWeatherData> GetCurrentWeatherDataByName(string CityName, HttpClient httpClient)
        {
            var uri = $"http://api.openweathermap.org/data/2.5/weather?q={CityName}&appid={AppId}&units=metric";
            return await GetJsonHttpClient<CurrentWeatherData>(uri, httpClient);
        }
    }
}
