using System.Text.Json;
using Canmore.Types;

namespace Canmore.Methods
{
    public class GetUpdates
    {
        public static async Task<Common<List<Update>>> RunAsync()
        {
            var request = await Client.SendRequestAsync($"{Data.GetUrl()}/getUpdates");
            var updateData = JsonSerializer.Deserialize<Common<List<Update>>> (request);
            return updateData;
        }
    }
}