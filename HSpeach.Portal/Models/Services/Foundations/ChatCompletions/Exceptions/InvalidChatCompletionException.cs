// ---------------------------------------------------------------
// Copyright (c) Coalition of the Good-Hearted Engineers
// FREE TO USE ALL GOOD HEART Developers
// ---------------------------------------------------------------

using Xeptions;

namespace HSpeach.Portal.Models.Services.Foundations.ChatCompletions.Exceptions
{
    public class InvalidChatCompletionException : Xeption
    {
        public InvalidChatCompletionException(string message)
            : base(message)
        { }

        public InvalidChatCompletionException(string message, Xeption innerException)
            : base(message, innerException)
        { }
    }
}
