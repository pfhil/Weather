using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using WeatherDomainModel.JSONResponse;

namespace WeatherDomainModel.Service.Interfaces
{
    public interface ICurrentWeatherService
    {
        public Task<CurrentWeatherData> GetCurrentWeatherDataByName(string CityName, HttpClient httpClient);
    }
}
