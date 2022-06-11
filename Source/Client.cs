namespace Canmore
{
    public class Client
    {
        private static HttpClient s_client = new HttpClient();

        public static async Task<Stream> SendRequestAsync(string url)
        {
            var request = await s_client.GetStreamAsync(url);
            if (request == null)
                throw new NullReferenceException();
            else
                return request;
        }
    }
}
