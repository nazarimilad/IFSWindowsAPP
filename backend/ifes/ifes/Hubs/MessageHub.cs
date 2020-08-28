using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ifes.Hubs
{
    public class MessageHub : Hub
    {


        public override async Task OnConnectedAsync()
        {
            Console.WriteLine(Context.ConnectionId);
            await base.OnConnectedAsync();
        }

        public override async Task OnDisconnectedAsync(Exception ex)
        {
            Console.WriteLine(Context.ConnectionId);
            await base.OnDisconnectedAsync(ex);
        }

        public async Task SendMessage(string user, string message)
        {
            await Clients.All.SendAsync("newMessage", user, message);
        }

        public async Task SendMessageFromCrewToPassenger(string user, string message)
        {
            await Clients.All.SendAsync("ReceiveMessage", user, message);
        }

        public async Task SendMessageFromCrewToAllPassengers(string user, string message)
        {
            await Clients.All.SendAsync("ReceiveMessage", user, message);
        }

    }
}
