using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;

namespace SignalRTest.Models
{
    public class ChatHub : Hub
    {
        public async Task SendMessage(string user, string message)
        {
            await Clients.All.SendAsync("ReceiveMessage", user, message);
           //await Clients.User(user).SendAsync("ReceiveMessage", user, message);

        }
    }
}