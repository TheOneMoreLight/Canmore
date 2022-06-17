using System.Text.Json.Serialization;

namespace Canmore.Types
{
    public record class Message
    {
        [JsonPropertyName("message_id")]
        public long MessageId { get; set; }

        [JsonPropertyName("chat")]
        public Chat Chat { get; set; }

        [JsonPropertyName("text")]
        public string Text { get; set; }
    }
}