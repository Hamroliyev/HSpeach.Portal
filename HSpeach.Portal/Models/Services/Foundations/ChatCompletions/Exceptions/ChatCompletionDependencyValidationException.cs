// ---------------------------------------------------------------
// Copyright (c) Coalition of the Good-Hearted Engineers
// FREE TO USE ALL GOOD HEART Developers
// ---------------------------------------------------------------

using Xeptions;

namespace HSpeach.Portal.Models.Services.Foundations.ChatCompletions.Exceptions
{
    public class ChatCompletionDependencyValidationException : Xeption
    {
        public ChatCompletionDependencyValidationException(string message, Xeption innerException)
            : base(message, innerException)
        { }
    }
}
