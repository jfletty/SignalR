using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;

namespace SignalR.Demo.Server
{
    public class ChatHub : Hub
    {
        public async Task StartupMessage()
        {
            await Clients.All.SendAsync("Server started and ready to receive");
        }
        
        public async Task SendMessage(string user, string message)
        {
            await Clients.All.SendAsync("ReceiveMessage", user, message);
        }
    }
}
