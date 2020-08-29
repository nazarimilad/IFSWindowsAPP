using Ifes.Services;
using Ifes.ViewModels;
using Microsoft.AspNetCore.SignalR.Client;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    public sealed partial class Chat : Page
    {


        public Chat()
        {
            this.InitializeComponent();
        }
        protected async override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            // _messages = MessagingService.Instance.Messages();
            await PassengersService.Instance.LoadReservationGroup();
            PeopleInGroup.ItemsSource = PassengersService.Instance.PassengersInReservationGroup;
        }

        private async void sendMessage_Click(object sender, RoutedEventArgs e)
        {
            await MessagingService.Instance.SendMessageToGroup("qlksdfjqsmldfkj");

        }
    }
}
