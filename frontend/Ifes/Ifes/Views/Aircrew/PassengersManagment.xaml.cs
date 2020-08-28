using Ifes.Services;
using Ifes.ViewModels;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Data.Json;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

namespace Ifes.Views.Aircrew
{
    public sealed partial class PassengersManagment : Page
    {
        public PassengersManagment()
        {
            this.InitializeComponent();
        }

        public async System.Threading.Tasks.Task<List<ViewModels.Passenger>> LoadDataAsync()
        {
            if (PassengersService.Instance.Passengers.Count == 0)
            {
                await PassengersService.Instance.LoadPassengers();
            }

            return PassengersService.Instance.Passengers;

        }

        protected override async void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            var passengers = await LoadDataAsync();

        }
    }
}
