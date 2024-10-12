// ---------------------------------------------------------------
// Copyright (c) Coalition of the Good-Hearted Engineers
// FREE TO USE ALL GOOD HEART Developers
// ---------------------------------------------------------------

using System;
using Xeptions;

namespace HSpeach.Portal.Models.Services.Foundations.ChatCompletions.Exceptions
{
    public class UnauthorizedChatCompletionException : Xeption
    {
        public UnauthorizedChatCompletionException(string message, Exception innerException)
            : base(message, innerException)
        { }
    }
}
