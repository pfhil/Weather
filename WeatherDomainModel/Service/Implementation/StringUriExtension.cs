using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherDomainModel.Service.Implementation
{
    public static class StringUriExtension
    {
        public static string AddCityName(this string uri, string CityName) => $"{uri}&q={CityName}";
        public static string UseUnits(this string uri, string Units) => $"{uri}&units={Units}";
        public static string UseLang(this string uri, string Language) => $"{uri}&lang={Language}";
    }
}
