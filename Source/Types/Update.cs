using System.Text.Json.Serialization;

namespace Canmore.Types
{
    public record class Update
    {
        [JsonPropertyName("update_id")]
        public long UpdateId { get; set; }

        [JsonPropertyName("message")]
        public Message Message { get; set; }

        [JsonPropertyName("edited_message")]
        public Message EditedMessage { get; set; }
    }
}