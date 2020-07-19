using Ifes.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ifes.ViewModels
{
    public class LiveFlightData : INotifyPropertyChanged
    {
        public int _speed;
        public int Speed
        {
            get { return _speed; }
            set
            {
                if (value != _speed)
                {
                    _speed = value;
                    NotifyPropertyChanged("Speed");
                }
            }
        }
        private int _altitude;
        public int Altitude
        {
            get { return _altitude; }
            set
            {
                if (value != _altitude)
                {
                    _altitude = value;
                    NotifyPropertyChanged("Altitude");
                }
            }
        }
        private int _temperature;
        public int Temperature
        {
            get { return _temperature; }
            set
            {
                if (value != _temperature)
                {
                    _temperature = value;
                    NotifyPropertyChanged("Temperature");
                }
            }
        }
        private string _etaTime;
        public string EtaTime
        {
            get { return _etaTime; }
            set
            {
                if (value != _etaTime)
                {
                    _etaTime = value;
                    NotifyPropertyChanged("EtaTime");
                }
            }
        }

        public LiveFlightData(int speed, int altitude, int temperature, string etaTime)
        {
            Speed = speed;
            Altitude = altitude;
            Temperature = temperature;
            EtaTime = etaTime;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged(String propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}