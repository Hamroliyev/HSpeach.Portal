// ---------------------------------------------------------------
// Copyright (c) Coalition of the Good-Hearted Engineers
// FREE TO USE ALL GOOD HEART Developers
// ---------------------------------------------------------------

using Xeptions;

namespace HSpeach.Portal.Models.Services.Foundations.ChatCompletions.Exceptions
{
    public class ChatCompletionDependencyException : Xeption
    {
        public ChatCompletionDependencyException(string message, Xeption innerException)
            : base(message, innerException)
        { }
    }
}
