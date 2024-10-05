// ---------------------------------------------------------------
// Copyright (c) Coalition of the Good-Hearted Engineers
// FREE TO USE ALL GOOD HEART Developers
// ---------------------------------------------------------------

using HSpeach.Portal.Models.ExternalCompletions;
using System.Threading.Tasks;

namespace HSpeach.Portal.Brokers.OpenAIs
{
    public partial class OpenAIBroker
    {
        public async ValueTask<ExternalCompletionResponse> PostCompletionRequestAsync(ExternalCompletionRequest completionRequest) =>
            await PostAsync<ExternalCompletionRequest, ExternalCompletionResponse>(relativeUrl: "v1/completions", completionRequest);
    }
}
