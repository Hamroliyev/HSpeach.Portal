// ---------------------------------------------------------------
// Copyright (c) Coalition of the Good-Hearted Engineers
// FREE TO USE ALL GOOD HEART Developers
// ---------------------------------------------------------------

using System;
using System.Threading.Tasks;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;
using Telegram.Bot.Types.ReplyMarkups;

namespace HSpeach.Portal.Brokers.Telegrams
{
    public interface ITelegramBroker
    {
        void RegisterTelegramEventHandler(Func<Update, ValueTask> eventHandler);

        ValueTask<Message> SendTextMessageAsync(long userTelegramId,
           string message,
           int? replyToMessageId = null,
           ParseMode? parseMode = null,
           IReplyMarkup replyMarkup = null);
        ValueTask DeleteMessageAsync(
            long userTelegramId,
            int messageId);
    }
}
