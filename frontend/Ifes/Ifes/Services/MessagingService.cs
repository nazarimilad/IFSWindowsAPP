using Ifes.ViewModels;
using Microsoft.AspNetCore.SignalR.Client;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ifes.Services
{
    public sealed class MessagingService
    {
        private static readonly Lazy<MessagingService> lazy = new Lazy<MessagingService>(() => new MessagingService());

        public static MessagingService Instance { get { return lazy.Value; } }

        private HubConnection _connection;

        private MessagingService()
        {
            Messages = new List<Message>();
        }

        public List<Message> Messages { get; set; }
        public async Task SetupSignalR()
        {
            Messages = new List<Message>();
            _connection = new HubConnectionBuilder().WithUrl("https://localhost:44319/messages").Build();
            await _connection.StartAsync();

        }


        public HubConnection Connection() { return _connection; }

        public async Task SendMessageToGroup(string content)
        {
            var psgr = AuthenticationService.Instance.Passenger;
            if (psgr != null)
            {
                await _connection.InvokeAsync("SendMessage", psgr.Id.ToString(), content);
            }
        }
        public async Task SendMessageToSeat(string content, string seat)
        {
            await _connection.InvokeAsync("SendMessageToSeat", seat, content);
        }
        public async Task SendMessageToAll(string content)
        {
            await _connection.InvokeAsync("SendMessageToSeatAll", content);
        }

        public void HandleIncomingMessage(Message message)
        {
            var psgr = AuthenticationService.Instance.Passenger;
            if (psgr != null)
            {
                if (message.UserFromId == psgr.Id || PassengersService.Instance.isUserMemberOfGroup(psgr.Id))
                {
                    Messages.Add(message);
                }
            }
        }

        public bool AllowedToDoActionMessage(Message message, int ctr)
        {
            var psgr = AuthenticationService.Instance.Passenger;
            if (ctr == Messages.Count())
            {
                return false;
            }
            if (psgr.Id == message.UserFromId)
            {
                return true;
            }
            return true;
        }

        public bool ShowAlert(Message message)
        {
            var psgr = AuthenticationService.Instance.Passenger;
            if (message.UserFromId == psgr.Id)
            {
                return true;
            }
            return false;
        }
    }
}
