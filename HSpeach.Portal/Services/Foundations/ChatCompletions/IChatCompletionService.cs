// ---------------------------------------------------------------
// Copyright (c) Coalition of the Good-Hearted Engineers
// FREE TO USE ALL GOOD HEART Developers
// ---------------------------------------------------------------

using HSpeach.Portal.Models.Services.Foundations.ChatCompletions;
using System.Threading.Tasks;

namespace HSpeach.Portal.Services.Foundations.ChatCompletions
{
    public interface IChatCompletionService
    {
        ValueTask<ChatCompletion> SendChatCompletionAsync(ChatCompletion chatCompletion);
    }
}
