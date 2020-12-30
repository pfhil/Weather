using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Telegram.Bot;
using System.Configuration;
using TelegramPhilBotWeather.Commands;
using Telegram.Bot.Args;

namespace TelegramPhilBotWeather    
{
    public static class Bot
    {
        private static TelegramBotClient client;

        private static List<Command> commandsList;

        public static IReadOnlyList<Command> Commands => commandsList.AsReadOnly();

        public static TelegramBotClient Get()
        {
            if (client != null)
            {
                return client;
            }

            commandsList = new List<Command>();
            commandsList.Add(new StartCommand());
            //TODO: Add more commands

            client = new TelegramBotClient(ConfigurationManager.AppSettings.Get("BotKey"));

            return client;
        }
    }
}
