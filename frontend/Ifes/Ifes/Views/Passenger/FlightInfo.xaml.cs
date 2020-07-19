using Ifes.Services;
using Ifes.ViewModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
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
        
    }
}
