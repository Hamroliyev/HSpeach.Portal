// ---------------------------------------------------------------
// Copyright (c) Coalition of the Good-Hearted Engineers
// FREE TO USE ALL GOOD HEART Developers
// ---------------------------------------------------------------

using Newtonsoft.Json;

namespace HSpeach.Portal.Models.ExternalCompletions
{
    public class ExternalCompletionUsage
    {
        [JsonProperty(propertyName: "prompt_tokens")]
        public int PromptTokens { get; set; }

        [JsonProperty(propertyName: "completion_tokens")]
        public int CompletionTokens { get; set; }

        [JsonProperty(propertyName: "total_tokens")]
        public int TotalTokens { get; set; }
    }
}
