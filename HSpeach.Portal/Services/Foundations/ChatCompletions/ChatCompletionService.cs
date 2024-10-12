// ---------------------------------------------------------------
// Copyright (c) Coalition of the Good-Hearted Engineers
// FREE TO USE ALL GOOD HEART Developers
// ---------------------------------------------------------------

using HSpeach.Portal.Brokers.DateTimes;
using HSpeach.Portal.Brokers.OpenAIs;
using HSpeach.Portal.Models.Services.Foundations.ChatCompletions;
using System.Threading.Tasks;

namespace HSpeach.Portal.Services.Foundations.ChatCompletions
{
    public partial class ChatCompletionService : IChatCompletionService
    {
        private readonly IOpenAIBroker openAIBroker;
        private readonly IDateTimeBroker dateTimeBroker;

        public ChatCompletionService(
            IOpenAIBroker openAIBroker,
            IDateTimeBroker dateTimeBroker)
        {
            this.openAIBroker = openAIBroker;
            this.dateTimeBroker = dateTimeBroker;
        }

        public ValueTask<ChatCompletion> SendChatCompletionAsync(ChatCompletion chatCompletion) =>
        TryCatch(async () =>
        {
            ValidateChatCompletionOnSend(chatCompletion);

            ExternalChatCompletionRequest externalChatCompletionRequest =
                ConvertToChatCompletionRequest(chatCompletion);

            ExternalChatCompletionResponse externalChatCompletionResponse =
                await this.openAIBroker.PostChatCompletionRequestAsync(externalChatCompletionRequest);

            return ConvertToChatCompletion(chatCompletion, externalChatCompletionResponse);
        });

        private static ExternalChatCompletionRequest ConvertToChatCompletionRequest(ChatCompletion chatCompletion)
        {
            return new ExternalChatCompletionRequest
            {
                Model = chatCompletion.Request.Model,

                Messages = chatCompletion.Request.Messages.Select(message =>
                {
                    return new ExternalChatCompletionMessage
                    {
                        Role = message.Role,
                        Content = message.Content
                    };
                }).ToArray(),

                Temperature = chatCompletion.Request.Temperature,
                ProbabilityMass = chatCompletion.Request.ProbabilityMass,
                CompletionsPerPrompt = chatCompletion.Request.CompletionsPerPrompt,
                Stream = chatCompletion.Request.Stream,
                Stop = chatCompletion.Request.Stop,
                MaxTokens = chatCompletion.Request.MaxTokens,
                PresencePenalty = chatCompletion.Request.PresencePenalty,
                FrequencyPenalty = chatCompletion.Request.FrequencyPenalty,
                LogitBias = chatCompletion.Request.LogitBias,
                User = chatCompletion.Request.User
            };
        }

        private ChatCompletion ConvertToChatCompletion(
            ChatCompletion chatCompletion,
            ExternalChatCompletionResponse externalChatCompletionResponse)
        {

            chatCompletion.Response = new ChatCompletionResponse
            {
                Id = externalChatCompletionResponse.Id,
                CreatedDate = this.dateTimeBroker.ConvertToDateTimeOffSet(externalChatCompletionResponse.Created),
                Choices = externalChatCompletionResponse.Choices.Select(choice =>
                {
                    return new ChatCompletionChoice
                    {
                        FinishReason = choice.FinishReason,
                        Index = choice.Index,

                        Message = new ChatCompletionMessage
                        {
                            Content = choice.Message.Content,
                            Role = choice.Message.Role
                        }
                    };

                }).ToArray(),
                Usage = new ChatCompletionUsage
                {
                    CompletionTokens = externalChatCompletionResponse.Usage.CompletionTokens,
                    PromptTokens = externalChatCompletionResponse.Usage.PromptTokens,
                    TotalTokens = externalChatCompletionResponse.Usage.TotalTokens
                },
                Object = externalChatCompletionResponse.Object
            };

            return chatCompletion;
        }
    }
}
