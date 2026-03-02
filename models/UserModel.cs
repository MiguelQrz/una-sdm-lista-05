using System.Text.Json.Serialization;

namespace ConsumerGithubUser.models
{
    public class UserModel
    {
        [JsonPropertyName("name")]
        public string? Name { get; set; }

        [JsonPropertyName("company")]
        public string? Company { get; set; }

        [JsonPropertyName("location")]
        public string? Local { get; set; }

        [JsonPropertyName("login")]
        public string? Login { get; set; }
    }
}