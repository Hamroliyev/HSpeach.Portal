// ---------------------------------------------------------------
// Copyright (c) Coalition of the Good-Hearted Engineers
// FREE TO USE ALL GOOD HEART Developers
// ---------------------------------------------------------------

using Newtonsoft.Json;

namespace HSpeach.Portal.Models.ExternalCompletions
{
    public class ExternalCompletionResponse
    {
        [JsonProperty(propertyName: "id")]
        public string Id { get; set; }

        [JsonProperty(propertyName: "_object")]
        public string Object { get; set; }

        [JsonProperty(propertyName: "created")]
        public int Created { get; set; }

        [JsonProperty(propertyName: "model")]
        public string Model { get; set; }

        [JsonProperty(propertyName: "choices")]
        public ExternalCompletionChoice[] Choices { get; set; }

        [JsonProperty(propertyName: "usage")]
        public ExternalCompletionUsage Usage { get; set; }
    }
}
