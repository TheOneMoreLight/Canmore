using Canmore.Types;
using Canmore.Methods;

namespace Canmore
{
    public class Handler
    {
        public async Task<Update> CatchLastUpdateAsync()
        {
            var updateObj = await GetUpdates.RunAsync();
            while (true)
            {
                if (updateObj.Result.Count != 0)
                    return updateObj.Result[updateObj.Result.Count - 1];
            }
        }

        public async Task HandleUpdateAsync()
        {
            var lastUpdate = await CatchLastUpdateAsync();
        }
    }

    /*
    public class Handler
    {
        public static async Task CatchUpdates()
        {
            var updateObj = await Methods.GetUpdates.RunAsync();
            var previousUpdate = new Update();          
            var currentUpdate = new Update();

            while (true)
            {
                if (updateObj.Result.Count != 0)
                {
                    previousUpdate = updateObj.Result[updateObj.Result.Count - 1];
                    currentUpdate = updateObj.Result[updateObj.Result.Count - 1];
                    break;
                }
            }

            while (true)
            {
                updateObj = await Methods.GetUpdates.RunAsync();
                currentUpdate = updateObj.Result[updateObj.Result.Count - 1];
                if (currentUpdate.UpdateId != previousUpdate.UpdateId)
                {
                    // await Methods.SendMessage.RunAsync(currentUpdate.Message.Chat.Id, currentUpdate.Message.Text);
                    previousUpdate = currentUpdate;
                }
            }
        }

        public static async Task HandleUpdates(Update update)
        {

        }
        
    }
    */
}