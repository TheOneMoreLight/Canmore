using System.Text.Json.Serialization;

namespace Canmore.Types
{   
    public record class Common<T>
    {
        [JsonPropertyName("ok")]
        public bool Ok { get; set; }

        [JsonPropertyName("result")]
        public T? Result { get; set; }
    }
}