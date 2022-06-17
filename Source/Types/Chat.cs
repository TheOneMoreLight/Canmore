using System.Text.Json.Serialization;

namespace Canmore.Types
{
    public record class Chat
    {
        [JsonPropertyName("id")]
        public long Id { get; set; }

        [JsonPropertyName("type")]
        public string Type { get; set; }
    }
}