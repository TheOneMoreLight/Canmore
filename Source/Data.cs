using System.Text.Json;
using System.Text.Json.Serialization;

namespace Canmore
{
    public class Data
    {
        public record class Constants
        {
            [JsonPropertyName("base_url")]
            public string? BaseUrl { get; set; }

            [JsonPropertyName("token")]
            public string? Token { get; set; }
        }
        
        public static Constants GetConstants()
        {
            StreamReader file = new StreamReader("Constants.json");
            var constants = JsonSerializer.Deserialize<Constants>(file.ReadToEnd());

            if (constants == null)
                throw new NullReferenceException();
            else
                return constants;
        }

        public static string GetUrl()
        {
            var constants = GetConstants();
            var url = constants.BaseUrl + constants.Token;
            return url;
        }
    }
}