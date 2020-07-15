﻿using System;
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

namespace Ifes.Passenger
{
    public sealed partial class Dashboard : Page
    {
        public Dashboard()
        {
            this.InitializeComponent();
            ContentFrame.Navigate(typeof(Passenger.FlightInformation));
            NavView.SelectedItem = NavView.MenuItems.ElementAt(0);
            this.SendSeatBeltNotification();
        }

        private void NavViewItemInvoked(NavigationView sender, NavigationViewItemInvokedEventArgs args)
        {
            var label = args.InvokedItem as string;
            var pageType =
                label == "Flight Information" ? typeof(Passenger.FlightInformation) :
                label == "Food and snacks" ? typeof(Passenger.FoodSnacks) :
                label == "Multimedia" ? typeof(Passenger.Multimedia):
                label == "Weather" ? typeof(Passenger.Weather):
                label == "Chat" ? typeof(Passenger.Chat): null;
            if (pageType != null && pageType != ContentFrame.CurrentSourcePageType)
            {
                ContentFrame.Navigate(pageType);
            }
        }

        private void OnClickLogOut(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Passenger.Login), null);
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