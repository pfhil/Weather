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

        protected static async Task<T> GetJsonHttpClientAsync<T>(string uri, HttpClient httpClient)
            where T : class
        {
            using HttpResponseMessage httpResponse = await httpClient.GetAsync(uri, HttpCompletionOption.ResponseHeadersRead);
            //TODO: Обработать ситуацию при отсутствии интернета
            string AppId = ConfigurationManager.AppSettings.Get("AppId");
            try
            {
                httpResponse.EnsureSuccessStatusCode(); // throws if not 200-299
            }
            catch (HttpRequestException ex)
            {
                switch (ex.StatusCode)
                {
                    case System.Net.HttpStatusCode.BadRequest:
                        throw new HttpRequestException("Запрос не может быть воспринят сервером");
                    case System.Net.HttpStatusCode.NotFound:
                        throw new HttpRequestException("Страница не найдена");
                    case System.Net.HttpStatusCode.RequestHeaderFieldsTooLarge:
                        goto case System.Net.HttpStatusCode.RequestUriTooLong;
                    case System.Net.HttpStatusCode.RequestUriTooLong:
                        throw new HttpRequestException("Слишком длинное название города");
                    case System.Net.HttpStatusCode.RequestTimeout:
                        throw new HttpRequestException("Превышено время ожидания от сервера");
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
