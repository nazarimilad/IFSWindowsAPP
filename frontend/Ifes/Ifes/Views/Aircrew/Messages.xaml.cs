using Ifes.Services;
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

namespace Ifes.Views.Aircrew
{
    public sealed partial class Messages : Page
    {
        public Messages()
        {
            this.InitializeComponent();
        }

        public ViewModels.Passenger SelectedPassenger = null;

        public string Message => this.SelectedPassenger == null ? "No passenger selected" : SelectedPassenger.UserName;
        public bool SendAllEnabled()
        {
            return (GetMessage() != null) && SelectedPassenger == null;
        }

        public bool SendOneEnabled()
        {
            return (GetMessage() != null) && this.SelectedPassenger != null;
        }


        private void OnBtnSendSingle(object sender, RoutedEventArgs e)
        {
            AlertMessageSend();

        }
        private void OnBtnSendAll(object sender, RoutedEventArgs e)
        {
            AlertMessageSend();
        }

        private void OnBtnClearSelected(object sender, RoutedEventArgs e)
        {
            SelectedPassenger = null;
            RecalculateState();
        }

        private string GetMessage()
        {
            return TextBoxMessage.Text;
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
            ListViewPassengers.ItemsSource = passengers;
        }

        private void ListViewPassengers_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.SelectedPassenger = (ViewModels.Passenger)e.ClickedItem;
            RecalculateState();
        }

        private void SearchPassenger_KeyUp(object sender, KeyRoutedEventArgs e)
        {
            ListViewPassengers.ItemsSource = PassengersService.Instance.Passengers.Where(p => p.MatchesSearch(SearchPassenger.Text));
            RecalculateState();
        }

        private void TextBoxMessage_KeyUp(object sender, KeyRoutedEventArgs e)
        {
            RecalculateState();
        }


        private void RecalculateState()
        {
            TxtTo.Text = Message;
            BtnSendMessageSingle.IsEnabled = SendOneEnabled();
            BtnSendMessageToAll.IsEnabled = SendAllEnabled();
        }

        private async void AlertMessageSend()
        {
            ContentDialog contentDialog= new ContentDialog()
            {
                Title = "Message send",
                Content = "Message send succesfully.",
                CloseButtonText = "Ok"
            };

            await contentDialog.ShowAsync();
            ClearScreen();
        }

       private void ClearScreen()
        {
            TextBoxMessage.Text = "";
            this.SelectedPassenger = null;
            this.RecalculateState();
        }

    }
}
