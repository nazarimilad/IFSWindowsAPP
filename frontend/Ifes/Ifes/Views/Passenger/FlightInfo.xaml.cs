using Ifes.Services;
using Ifes.ViewModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Core;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

namespace Ifes.Views.Passenger
{
    public sealed partial class FlightInfo : Page
    {
        public AirPlaneInfo AirPlaneInfo {
            get {
                return FlightInfoService.Instance.AirPlaneInfo;
            }
        }
        public ViewModels.FlightInfo FlightInfoValue {
            get {
                return FlightInfoService.Instance.FlightInfo;
            }
        }
        public LiveFlightData LiveFlightData {
            get {
                return FlightInfoService.Instance.LiveFlightData;
            }
        }
        public Weather Weather
        {
            get
            {
                return WeatherService.Instance.Weather;
            }
        }

        public FlightInfo()
        {
            this.InitializeComponent();
        }

        private async Task StartUpdatingLiveFlightDataAsync()
        {
            // TODO: make http request and deserialise JSON result into corresponding view model
            await this.Dispatcher.RunAsync(CoreDispatcherPriority.Normal, async () =>
             {
                 while (true)
                 {
                     Random rnd = new Random();
                     LiveFlightData newLiveFlightdata = FlightInfoService.Instance.GetLiveFlightData().Result;
                     LiveFlightData.Speed = newLiveFlightdata.Speed;
                     LiveFlightData.Altitude = newLiveFlightdata.Altitude;
                     LiveFlightData.Temperature = newLiveFlightdata.Temperature;
                     LiveFlightData.EtaTime = newLiveFlightdata.EtaTime;
                     await Task.Delay(5000); // <- await with cancellation
                }
             });
        }

        protected async override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            await WeatherService.Instance.GetWeather();
             await  StartUpdatingLiveFlightDataAsync();

        }
    }
}
