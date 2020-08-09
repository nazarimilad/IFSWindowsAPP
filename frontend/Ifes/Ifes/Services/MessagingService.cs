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



            _connection = new HubConnectionBuilder()
                .WithUrl("https://example.com/chathub", options =>
                {
                    options.AccessTokenProvider = () => Task.FromResult(_myAccessToken);
                })
                .WithAutomaticReconnect()


            //debug
            _messages.Add(new Message { Content = "qlskdfjqsmldfkj" });
            _messages.Add(new Message { Content = "qlskdfjqsmldfkj" });
            _messages.Add(new Message { Content = "qlskdfjqsmldfkj" });
            _messages.Add(new Message { Content = "qlskdfjqsmldfkj" });
            _messages.Add(new Message { Content = "qlskdfjqsmldfkj" });
            _messages.Add(new Message { Content = "qlskdfjqsmldfkj" });

        }

        public ObservableCollection<Message> Messages() { return _messages; }


        public void AddNewMessage(Message message)
        {
            _messages.Add(message);
        }


        public void SendMessage(string message)
        {
            _hubProxy.Invoke("send", message);
        }

        
        public HubConnection Connection() { return _connection; }


    }
}
