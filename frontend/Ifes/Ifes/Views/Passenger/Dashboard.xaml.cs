using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading;
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
    public sealed partial class Dashboard : Page
    {
        public Dashboard()
        {
            this.InitializeComponent();
            ContentFrame.Navigate(typeof(Passenger.FlightInfo));
            NavView.SelectedItem = NavView.MenuItems.ElementAt(0);
            this.SendSeatBeltNotification();
        }

        private void NavViewItemInvoked(NavigationView sender, NavigationViewItemInvokedEventArgs args)
        {
            var label = args.InvokedItem as string;
            var pageType =
                label == "Flight Info" ? typeof(Views.Passenger.FlightInfo) :
                label == "Food & snacks" ? typeof(Views.Passenger.FoodSnacks) :
                label == "Media" ? typeof(Views.Passenger.Media):
                label == "Weather" ? typeof(Views.Passenger.Weather):
                label == "Chat" ? typeof(Views.Passenger.Chat): null;
            if (pageType != null && pageType != ContentFrame.CurrentSourcePageType)
            {
                ContentFrame.Navigate(pageType);
            }
        }

        private void OnClickLogOut(object sender, TappedRoutedEventArgs e)
        {
            // TODO: let viewmodel of logged user call LogOut() method of AuthenticationService
            this.Frame.Navigate(typeof(Views.Passenger.Login), null);
        }

        private void OnClickMyOrders(object sender, TappedRoutedEventArgs e)
        {
            ContentFrame.Navigate(typeof(Views.Passenger.Orders));
        }

        private async void SendSeatBeltNotification()
        {
            ContentDialog seatBeltDialog = new ContentDialog()
            {
                Title = "Dear passenger",
                Content = "Make sure to fasten your seat belt.",
                PrimaryButtonText = "Ok",
            };
            await Task.Delay(5000);
            await seatBeltDialog.ShowAsync();
        }

        
    }
}
