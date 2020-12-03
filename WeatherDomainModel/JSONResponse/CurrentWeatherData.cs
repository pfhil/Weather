using Newtonsoft.Json;

namespace WeatherDomainModel.JSONResponse
{
    public class CurrentWeatherData
    {
        [JsonProperty(PropertyName = "coord")]
        public Coord Coord { get; set; }

        [JsonProperty(PropertyName = "weather")]
        public Weather[] Weather { get; set; }

        [JsonProperty(PropertyName = "_base")]
        public string Base { get; set; }

        [JsonProperty(PropertyName = "main")]
        public Main Main { get; set; }

        [JsonProperty(PropertyName = "visibility")]
        public int Visibility { get; set; }

        [JsonProperty(PropertyName = "wind")]
        public Wind Wind { get; set; }

        [JsonProperty(PropertyName = "clouds")]
        public Clouds Clouds { get; set; }

        [JsonProperty(PropertyName = "dt")]
        public int TimeOfDataCalculation { get; set; }

        [JsonProperty(PropertyName = "sys")]
        public Sys Sys { get; set; }

        [JsonProperty(PropertyName = "id")]
        public int CityId { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string CityName { get; set; }

        [JsonProperty(PropertyName = "cod")]
        public int Cod { get; set; }
    }

    public class Coord
    {
        [JsonProperty(PropertyName = "lon")]
        public float Longitude { get; set; }

        [JsonProperty(PropertyName = "lat")]
        public float Latitude { get; set; }
    }

    public class Main
    {
        [JsonProperty(PropertyName = "temp")]
        public float Temp { get; set; }

        [JsonProperty(PropertyName = "pressure")]
        public int Pressure { get; set; }

        [JsonProperty(PropertyName = "humidity")]
        public int Humidity { get; set; }

        [JsonProperty(PropertyName = "temp_min")]
        public float TempMin { get; set; }

        [JsonProperty(PropertyName = "temp_max")]
        public float TempMax { get; set; }
    }

    public class Wind
    {
        [JsonProperty(PropertyName = "speed")]
        public float Speed { get; set; }

        [JsonProperty(PropertyName = "deg")]
        public int Direction { get; set; }
    }

    public class Clouds
    {
        [JsonProperty(PropertyName = "all")]
        public int Percent { get; set; }
    }

    public class Sys
    {
        [JsonProperty(PropertyName = "type")]
        public int Type { get; set; }

        [JsonProperty(PropertyName = "id")]
        public int Id { get; set; }

        [JsonProperty(PropertyName = "message")]
        public float Message { get; set; }

        [JsonProperty(PropertyName = "country")]
        public string CountryCode { get; set; }

        [JsonProperty(PropertyName = "sunrise")]
        public int Sunrise { get; set; }

        [JsonProperty(PropertyName = "sunset")]
        public int Sunset { get; set; }
    }

    public class Weather
    {
        [JsonProperty(PropertyName = "id")]
        public int Id { get; set; }

        [JsonProperty(PropertyName = "main")]
        public string Main { get; set; }

        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        [JsonProperty(PropertyName = "icon")]
        public string Icon { get; set; }
    }
}
