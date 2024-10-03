// ---------------------------------------------------------------
// Copyright (c) Coalition of the Good-Hearted Engineers
// FREE TO USE ALL GOOD HEART Developers
// ---------------------------------------------------------------

namespace HSpeach.Portal.Models.Configurations
{
    public class OpenAIConfigurations
    {
        public string ApiUrl { get; set; } = "https://api.openai.com/v1";
        public string ApiKey { get; set; }
        public string OrganizationId { get; set; }
    }
}
