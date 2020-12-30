using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Types;

namespace TelegramPhilBotWeather.Commands
{
    public class StartCommand : Command
    {
        public override string Name => @"/start";

        public override async Task Execute(Message message, TelegramBotClient botClient)
        {
            var chatId = message.Chat.Id;
            await botClient.SendTextMessageAsync(chatId, "Привет. Я бот, который дает прогноз погоды. Просто введи имя города и я тебе дам о нем метеосводку на настоящий момент.", parseMode: Telegram.Bot.Types.Enums.ParseMode.Markdown);
        }
    }
}