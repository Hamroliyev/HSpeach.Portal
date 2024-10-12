// ---------------------------------------------------------------
// Copyright (c) Coalition of the Good-Hearted Engineers
// FREE TO USE ALL GOOD HEART Developers
// ---------------------------------------------------------------

namespace HSpeach.Portal.Models.Services.Foundations.ChatCompletions
{
    public class ChatCompletionChoice
    {
        public int Index { get; set; }
        public ChatCompletionMessage Message { get; set; }
        public string FinishReason { get; set; }
    }
}
