using Newtonsoft.Json;

namespace WeatherDomainModel.JSONResponse
{
    public class ForecastWeatherData
    {
        [JsonProperty(PropertyName = "cod")]
        public string Cod { get; set; }

        [JsonProperty(PropertyName = "message")]
        public int Message { get; set; }

        [JsonProperty(PropertyName = "cnt")]
        public int NumberOfTimeStamps { get; set; }

        [JsonProperty(PropertyName = "list")]
        public List[] List { get; set; }

        [JsonProperty(PropertyName = "city")]
        public City Сity { get; set; }
    }

    public class City
    {
        [JsonProperty(PropertyName = "id")]
        public int Id { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "coord")]
        public Coord Coord { get; set; }

        [JsonProperty(PropertyName = "country")]
        public string Country { get; set; }

        [JsonProperty(PropertyName = "population")]
        public int Population { get; set; }

        [JsonProperty(PropertyName = "timezone")]
        public int Timezone { get; set; }

        [JsonProperty(PropertyName = "sunrise")]
        public int Sunrise { get; set; }

        [JsonProperty(PropertyName = "sunset")]
        public int Sunset { get; set; }
    }

    //public class Coord
    //{
    //    public float lat { get; set; }
    //    public float lon { get; set; }
    //}

    public class List
    {
        [JsonProperty(PropertyName = "dt")]
        public int DateTime { get; set; }

        [JsonProperty(PropertyName = "main")]
        public MainForecast Main { get; set; }

        [JsonProperty(PropertyName = "weather")]
        public Weather[] Weather { get; set; }

        [JsonProperty(PropertyName = "clouds")]
        public Clouds Clouds { get; set; }

        [JsonProperty(PropertyName = "wind")]
        public Wind Wind { get; set; }

        [JsonProperty(PropertyName = "visibility")]
        public int Visibility { get; set; }

        [JsonProperty(PropertyName = "pop")]
        public float ProbabilityOfPrecipitation { get; set; }

        [JsonProperty(PropertyName = "rain")]
        public Rain Rain { get; set; }

        [JsonProperty(PropertyName = "sys")]
        public SysForecast Sys { get; set; }

        [JsonProperty(PropertyName = "dt_txt")]
        public string DateTimetxt { get; set; }
    }

    public class MainForecast
    {
        [JsonProperty(PropertyName = "temp")]
        public float Temp { get; set; }

        [JsonProperty(PropertyName = "feels_like")]
        public float FeelsLike { get; set; }

        [JsonProperty(PropertyName = "temp_min")]
        public float TempMin { get; set; }

        [JsonProperty(PropertyName = "temp_max")]
        public float TempMax { get; set; }

        [JsonProperty(PropertyName = "pressure")]
        public int Pressure { get; set; }

        [JsonProperty(PropertyName = "sea_level")]
        public int SeaLevel { get; set; }

        [JsonProperty(PropertyName = "grnd_level")]
        public int GroundLevel { get; set; }

        [JsonProperty(PropertyName = "humidity")]
        public int Humidity { get; set; }

        [JsonProperty(PropertyName = "temp_kf")]
        public float TempKF { get; set; }
    }

    //public class Clouds
    //{
    //    public int all { get; set; }
    //}

    //public class Wind
    //{
    //    public float speed { get; set; }
    //    public int deg { get; set; }
    //}

    public class Rain
    {
        [JsonProperty(PropertyName = "_3h")]
        public float RainVolumeForLast3Hours { get; set; }
    }

    public class SysForecast
    {
        [JsonProperty(PropertyName = "pod")]
        public string PartOfTheDay { get; set; }
    }

    //public class Weather
    //{
    //    public int id { get; set; }
    //    public string main { get; set; }
    //    public string description { get; set; }
    //    public string icon { get; set; }
    //}
}