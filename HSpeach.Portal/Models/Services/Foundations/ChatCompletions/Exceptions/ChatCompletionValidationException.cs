// ---------------------------------------------------------------
// Copyright (c) Coalition of the Good-Hearted Engineers
// FREE TO USE ALL GOOD HEART Developers
// ---------------------------------------------------------------

using Xeptions;

namespace HSpeach.Portal.Models.Services.Foundations.ChatCompletions.Exceptions
{
    public class ChatCompletionValidationException : Xeption
    {
        public ChatCompletionValidationException(string message, Xeption innerException)
            : base(message, innerException)
        { }
    }
}
