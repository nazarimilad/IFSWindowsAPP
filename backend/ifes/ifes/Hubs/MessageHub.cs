﻿using ifes.lib.data;
using ifes.lib.DTOs.Messages;
using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ifes.Hubs
{
    public class MessageHub : Hub
    {
        private readonly ApplicationDbContext _context;

        public MessageHub(ApplicationDbContext context)
        {
            _context = context;
        }

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

            var passenger = _context.Passenger.FirstOrDefault(predicate => predicate.Id == user);
            var msg = new Message
            {
                Content = message,
                UserFrom = passenger.UserName,
                SentDate = DateTime.Now,
                UserFromId = passenger.Id,
                Id = Guid.NewGuid()
            };

            await Clients.All.SendAsync("newMessage", user, msg);
        }

        public async Task SendMessageToSeat( string message, string seat)
        {
            await Clients.All.SendAsync("CrewMessageSingle", message, seat);
        }

        public async Task SendMessageToSeatAll( string message)
        {
            await Clients.All.SendAsync("CrewMessageAll", message);
        }

    }
}
