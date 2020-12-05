using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;
using System.Configuration;
using System.Collections.Specialized;

namespace WeatherDomainModel.Service.Implementation
{
    public abstract class BaseService
    {
        protected static string AppId = ConfigurationManager.AppSettings.Get("AppId");

        protected static async Task<T> GetJsonHttpClient<T>(string uri, HttpClient httpClient)
            where T : class
        {
            using var httpResponse = await httpClient.GetAsync(uri, HttpCompletionOption.ResponseHeadersRead);

            try
            {
                httpResponse.EnsureSuccessStatusCode(); // throws if not 200-299
            }
            catch (HttpRequestException ex)
            {
                switch (ex.StatusCode)
                {
                    case System.Net.HttpStatusCode.NotFound:
                        throw new HttpRequestException("Страница не найдена");
                    default:
                        break;
                }
            }
            

            if (httpResponse.Content is object && httpResponse.Content.Headers.ContentType.MediaType == "application/json")
            {
                var contentStream = await httpResponse.Content.ReadAsStreamAsync();

                using var streamReader = new StreamReader(contentStream);
                using var jsonReader = new JsonTextReader(streamReader);

                JsonSerializer serializer = new JsonSerializer();
                
                try
                {
                    return serializer.Deserialize<T>(jsonReader);
                }
                catch (JsonReaderException)
                {
                    throw new JsonReaderException("Инвалид JSON");
                }
            }
            else
            {
                //("HTTP Response was invalid and cannot be deserialised.");
            }

            return null;
        }

    }
}
