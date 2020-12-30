using System;
using Telegram.Bot;
using System.Configuration;
using TelegramPhilBotWeather.Commands;
using Telegram.Bot.Args;
using WeatherDomainModel.JSONResponse;
using WeatherDomainModel.Service.Implementation;
using System.Net.Http;
using System.Threading.Tasks;
using WeatherPresentation.Common;
using WeatherDomainModel.Service.Interfaces;
using System.Linq;

namespace TelegramPhilBotWeather
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var Client = Bot.Get();

            Client.OnMessage += BotOnMessage;
            Client.StartReceiving();

            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }

        static async void BotOnMessage(object sender, MessageEventArgs e)
        {
            if (!string.IsNullOrEmpty(e.Message.Text))
            {
                var commands = Bot.Commands;
                var message = e.Message;
                var BotClient = Bot.Get();

                foreach (var command in commands)
                {
                    if (command.Contains(message))
                    {
                        await command.Execute(message, BotClient);
                        return;
                    }
                }

                await SendWeatherAsync(message, BotClient);

            }
        }

        private static async Task SendWeatherAsync(Telegram.Bot.Types.Message message, TelegramBotClient BotClient)
        {
            WeatherInfo WeatherInfo;
            try
            {
                var service = new CurrentWeatherService();
                CurrentWeatherData Response = await Task.Run(() => service.GetCurrentWeatherDataByCityName(message.Text, SingletonHttpClient.GetInstance()));
                WeatherInfo = new WeatherInfo()
                {
                    Temp = Response.Main.Temp.ToString(),
                    Description = Response.Weather.FirstOrDefault().Description,
                    Visibility = $"{Response.Visibility} метров",
                    WindSpeed = $"{Response.Wind.Speed} м/с",
                    WindDirection = Response.Wind.Direction.ToString(),
                    CloudsPercent = $"{Response.Clouds.Percent}%",
                    CountryCode = Response.Sys.CountryCode,
                    Sunrise = TimeSpan.FromSeconds(Response.Sys.Sunrise).ToString(@"hh\:mm\:ss"),
                    Sunset = TimeSpan.FromSeconds(Response.Sys.Sunset).ToString(@"hh\:mm\:ss")
                };
            }
            catch (HttpRequestException ex)
            {
                await BotClient.SendTextMessageAsync(message.Chat.Id, ex.Message);
                return;
            }
            catch (Exception)
            {
                await BotClient.SendTextMessageAsync(message.Chat.Id, "Произошла непредвиденная ошибка.\nПожалуйста свяжитесь с разработчиками.");
                return;
            }
            await BotClient.SendTextMessageAsync(message.Chat.Id,
                $"Код страны {WeatherInfo.CountryCode}\n" +
                $"Температура {WeatherInfo.Temp}\n" +
                $"Описание {WeatherInfo.Description}\n" +
                $"Видимость {WeatherInfo.Visibility}\n\n" +
                $"Ветер:\n" +
                $"Направление {WeatherInfo.WindDirection}\n" +
                $"Скорость {WeatherInfo.WindSpeed}\n\n" +
                $"Облачность {WeatherInfo.CloudsPercent}\n" +
                $"Рассвет в {WeatherInfo.Sunrise}\n" +
                $"Закат в {WeatherInfo.Sunset}\n");
        }
    }
}
