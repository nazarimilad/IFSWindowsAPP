using Ifes.Helpers;
using Ifes.Services;
using Ifes.ViewModels;
using Microsoft.AspNetCore.SignalR.Client;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading;
using System.Threading.Tasks;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Networking.BackgroundTransfer;
using Windows.Storage;
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
        public Messaging Messaging;

        public Dashboard()
        {
            this.InitializeComponent();
            Messaging = new Messaging();
            ChatNotification.DataContext = Messaging;
            ContentFrame.Navigate(typeof(Passenger.FlightInfo));
            NavView.SelectedItem = NavView.MenuItems.ElementAt(0);
        }

        private async void NavViewItemInvoked(NavigationView sender, NavigationViewItemInvokedEventArgs args)
        {
            var label = args.InvokedItem as string;
            var pageType =
                label == "Flight Info" ? typeof(Views.Passenger.FlightInfo) :
                label == "Meals & Beverages" ? typeof(Views.Passenger.MealsBeveragesView) :
                label == "Media" ? typeof(Views.Passenger.Media) :
                label == "Chat" ? typeof(Views.Passenger.Chat) :
                label == "My Orders" ? typeof(Views.Passenger.Orders) :
                null;
            if (pageType != null && pageType != ContentFrame.CurrentSourcePageType)
            {
                ContentFrame.Navigate(pageType);
            }

        }


        private async void LoadChatSignalRAsync()
        {
            MessagingService.Instance.Messages = new List<Message>();
            await MessagingService.Instance.SetupSignalR();
            MessagingService.Instance.Connection().On<string, Message>("newMessage", async (user, message) =>
            {
                await Dispatcher.RunAsync(CoreDispatcherPriority.Normal, () =>
                {
                    var before = MessagingService.Instance.Messages.Count();
                    MessagingService.Instance.HandleIncomingMessage(message);
                    if (MessagingService.Instance.AllowedToDoActionMessage(message, before))
                    {
                        SendNewMessageNotification(message);
                    }
                });
            });

            MessagingService.Instance.Connection().On<string>("CrewMessageAll", async (message) =>
            {
                await Dispatcher.RunAsync(CoreDispatcherPriority.Normal, () =>
                {
                    SendCrewNotification(message);
                });
            });


            MessagingService.Instance.Connection().On<string, string>("CrewMessageSingle", async (message, passengerId) =>
            {
                await Dispatcher.RunAsync(CoreDispatcherPriority.Normal, () =>
                {
                    if (MessagingService.Instance.ShowAlert(passengerId))
                    {
                        SendCrewNotification(message);
                    }
                });
            });

        }





        private async void OnClickLogOut(object sender, TappedRoutedEventArgs e)
        {
            ContentDialog confirmationDialog = new ContentDialog()
            {
                Title = "Log out",
                Content = "Are you sure you want to log out?",
                PrimaryButtonText = "Yes",
                CloseButtonText = "Cancel",
                DefaultButton = ContentDialogButton.Close
            };
            ContentDialogResult result = await confirmationDialog.ShowAsync();
            if (result == ContentDialogResult.Primary)
            {
                // TODO: let viewmodel of logged user call LogOut() method of AuthenticationService
                this.Frame.Navigate(typeof(Views.Passenger.Login), null);
            }
        }

        private void OnClickMyOrders(object sender, TappedRoutedEventArgs e)
        {
            ContentFrame.Navigate(typeof(Views.Passenger.Orders));
        }

        private async void SendCrewNotification(string message)
        {
            ContentDialog seatBeltDialog = new ContentDialog()
            {
                Title = "Dear passenger",
                Content = message,
                PrimaryButtonText = "Ok",
                DefaultButton = ContentDialogButton.Primary
            };
            await seatBeltDialog.ShowAsync();
        }
        private void SendNewMessageNotification(Message message)
        {
            object inAppNotificationWithButtonsTemplate = null;
            bool? isTemplatePresent = Resources.TryGetValue("InAppNotificationWithButtonsTemplate", out inAppNotificationWithButtonsTemplate);
            if (isTemplatePresent == true && inAppNotificationWithButtonsTemplate is DataTemplate template)
            {
                Messaging.ReceivedMessage = message.Preview();
                ChatNotification.Show(template, 10_000);
            }
        }


        private async void OnClickDownLoadExcel(object sender, RoutedEventArgs e)
        {

            try
            {
                using (var client = HttpClientWithToken.GetClient())
                {
                    var response = await client.GetAsync(new Uri("https://localhost:44319/api/Order/GetPassengerOrdersSpreadsheet?passengerId=" + $"{AuthenticationService.Instance.Passenger.Id}&formatType=xls", UriKind.Absolute));
                    Windows.Storage.StorageFolder storageFolder = Windows.Storage.ApplicationData.Current.LocalFolder;
                    Windows.Storage.StorageFile file = await DownloadsFolder.CreateFileAsync($"{AuthenticationService.Instance.Passenger.Id}.xlsx",
                            Windows.Storage.CreationCollisionOption.GenerateUniqueName);
                    var data = await response.Content.ReadAsByteArrayAsync();
                    await Windows.Storage.FileIO.WriteBytesAsync(file, data);
                }
                ContentDialog seatBeltDialog = new ContentDialog()
                {
                    Title = "Dear passenger",
                    Content = $"Your receipt has been downloaded in the downloads folder under the name of {AuthenticationService.Instance.Passenger.Id}.xlsx",
                    PrimaryButtonText = "Ok",
                    DefaultButton = ContentDialogButton.Primary
                };
                await seatBeltDialog.ShowAsync();
            }
            catch (Exception)
            {

                ContentDialog seatBeltDialog = new ContentDialog()
                {
                    Title = "Dear passenger",
                    Content = $"Your receipt couldnt be printed",
                    PrimaryButtonText = "Ok",
                    DefaultButton = ContentDialogButton.Primary
                };
                await seatBeltDialog.ShowAsync();
            }

          
        }
        private void OnClickBtnReply(object sender, RoutedEventArgs e)
        {
            ContentFrame.Navigate(typeof(Views.Passenger.Chat));
            NavView.SelectedItem = NavView.MenuItems.ElementAt(3);
        }

        protected async override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            LoadChatSignalRAsync();
            await PassengersService.Instance.LoadPassengers();
        }

        private async void OnclickSimulateMessageCrew(object sender, TappedRoutedEventArgs e)
        {
            await MessagingService.Instance.SendMessageToAll("Simulated message from crew");
        }
    }
}
