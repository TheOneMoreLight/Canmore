using System.Text.Json;
using Canmore.Types;

namespace Canmore.Methods
{
    public class GetMe
    {
        public static async Task<Common<User>> RunAsync()
        {
            var request = await Client.SendRequestAsync($"{Data.GetUrl()}/getMe");
            var botData = JsonSerializer.Deserialize<Common<User>> (request);
            return botData;
        }
    }
}