using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;

namespace PrabhjeetSinghChat.Server.Hubs
{
    public class ChatHub : Hub
    {
        
    public Task SendMessage(string user, string message)
        {

            return Clients.All.SendAsync("CommingMessageFromAUser", user, message);
        }
    public Task onfocus(string message)
        {

            return Clients.Others.SendAsync("typing", message);
        }
  }
}