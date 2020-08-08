using Ifes.ViewModels;
using Microsoft.AspNet.SignalR.Client;
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
        private IHubProxy _hubProxy;

        private MessagingService()
        {

            _connection = new HubConnection("http://localhost:5001/chathub");
            _hubProxy = _connection.CreateHubProxy("chat");


            //debug
            _messages.Add(new Message { Content = "qlskdfjqsmldfkj" });
            _messages.Add(new Message { Content = "qlskdfjqsmldfkj" });
            _messages.Add(new Message { Content = "qlskdfjqsmldfkj" });
            _messages.Add(new Message { Content = "qlskdfjqsmldfkj" });
            _messages.Add(new Message { Content = "qlskdfjqsmldfkj" });
            _messages.Add(new Message { Content = "qlskdfjqsmldfkj" });

        }

        public ObservableCollection<Message> Messages() { return _messages; }


        public void AddNewMessage(Message message) {
            _messages.Add(message);
        }


        public void SendMessage(string message)
        {
            _hubProxy.Invoke("send", message);
        }

        public IHubProxy HubProxy() { return _hubProxy; }
        public HubConnection Connection() { return _connection; }


    }
}
