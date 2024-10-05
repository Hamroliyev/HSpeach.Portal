// ---------------------------------------------------------------
// Copyright (c) Coalition of the Good-Hearted Engineers
// FREE TO USE ALL GOOD HEART Developers
// ---------------------------------------------------------------

using Newtonsoft.Json;

namespace HSpeach.Portal.Models.ExternalCompletions
{
    public class ExternalCompletionChoice
    {
        [JsonProperty(propertyName: "text")]
        public string Text { get; set; }

        [JsonProperty(propertyName: "index")]
        public int Index { get; set; }

        [JsonProperty(propertyName: "logprobs")]
        public object LogProbabilities { get; set; }

        [JsonProperty(propertyName: "finish_reason")]
        public string FinishReason { get; set; }
    }
}
