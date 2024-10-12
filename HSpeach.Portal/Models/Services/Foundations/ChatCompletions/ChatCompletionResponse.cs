// ---------------------------------------------------------------
// Copyright (c) Coalition of the Good-Hearted Engineers
// FREE TO USE ALL GOOD HEART Developers
// ---------------------------------------------------------------

using System;

namespace HSpeach.Portal.Models.Services.Foundations.ChatCompletions
{
    public class ChatCompletionResponse
    {
        public string Id { get; set; }
        public string Object { get; set; }
        public DateTimeOffset CreatedDate { get; set; }
        public ChatCompletionChoice[] Choices { get; set; }
        public ChatCompletionUsage Usage { get; set; }
    }
}
