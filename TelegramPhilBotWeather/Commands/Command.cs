using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Types;
using System.Configuration;

namespace TelegramPhilBotWeather.Commands
{
    public abstract class Command
    {
        public abstract string Name { get; }

        public abstract Task Execute(Message message, TelegramBotClient client);
        public bool Contains(Message message)
        {
            return message.Text.Contains(this.Name);
            //&& command.Contains(ConfigurationManager.AppSettings.Get("BotName"))
            //На случай если бот будет в беседах
        }
    }
}
