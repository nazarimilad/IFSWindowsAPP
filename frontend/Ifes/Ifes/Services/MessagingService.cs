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

        private ObservableCollection<Message> _messages = new ObservableCollection<Message>();
        private HubConnection _connection;

        private MessagingService()
        {



            SetupSignalR();
            //debug
            _messages.Add(new Message { Content = "qlskdfjqsmldfkj" });
            _messages.Add(new Message { Content = "qlskdfjqsmldfkj" });
            _messages.Add(new Message { Content = "qlskdfjqsmldfkj" });
            _messages.Add(new Message { Content = "qlskdfjqsmldfkj" });
            _messages.Add(new Message { Content = "qlskdfjqsmldfkj" });
            _messages.Add(new Message { Content = "qlskdfjqsmldfkj" });

        }

        public ObservableCollection<Message> Messages() { return _messages; }

        private async Task SetupSignalR()
        {
            _connection = new HubConnectionBuilder().WithUrl("https://localhost:44319/messages").Build();

            await _connection.StartAsync();

        }


        public void AddNewMessage(Message message)
        {
            _messages.Add(message);
        }

        public HubConnection Connection() { return _connection; }


    }
}
