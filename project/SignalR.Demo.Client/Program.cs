using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR.Client;

namespace SignalR.Demo.Client
{
    class Program
    {
        private static async Task Main()
        {
            var connection = new HubConnectionBuilder().WithUrl("https://localhost:5001/chatHub").Build();
            var messageHandler = new MessageHandler(connection);
            await messageHandler.HandleMessage();
        }
    }
}