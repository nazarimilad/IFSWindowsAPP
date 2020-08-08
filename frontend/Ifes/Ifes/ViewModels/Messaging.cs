using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ifes.ViewModels
{
    public class Messaging: INotifyPropertyChanged
    {
        public string _receivedMessage;
        public string ReceivedMessage {
            get
            {
                return _receivedMessage;
            }
            set
            {
                if (value != _receivedMessage)
                {
                    _receivedMessage = value;
                    NotifyPropertyChanged("ReceivedMessage");
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged(String propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }



    }
}
