namespace Canmore.Methods
{
    public class SendMessage
    {
        public static async Task RunAsync(long chat_id, string text)
        {
            var request = await Client.SendRequestAsync($"{Data.GetUrl()}/sendMessage?chat_id={chat_id}&text={text}"); /*You+are+gay*/
        }
    }
}