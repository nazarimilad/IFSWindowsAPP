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
    public sealed partial class Dashboard : Page
    {
        public Dashboard()
        {
            this.InitializeComponent();
            ContentFrame.Navigate(typeof(Views.Aircrew.Messages));
            NavView.SelectedItem = NavView.MenuItems.ElementAt(0);
        }

        private void NavViewItemInvoked(NavigationView sender, NavigationViewItemInvokedEventArgs args)
        {
            var label = args.InvokedItem as string;
            var pageType =
                label == "Messages" ? typeof(Views.Aircrew.Messages) :
                label == "Passengers" ? typeof(Views.Aircrew.PassengersManagment) : null;
            if (pageType != null && pageType != ContentFrame.CurrentSourcePageType)
            {
                ContentFrame.Navigate(pageType);
            }
        }

        private async void OnClickLogOut(object sender, TappedRoutedEventArgs e)
        {
            ContentDialog confirmationDialog = new ContentDialog()
            {
                Title = "Log out",
                Content = "Are you sure you want to log out?",
                PrimaryButtonText = "Yes",
                CloseButtonText = "Cancel",
            };
            ContentDialogResult result = await confirmationDialog.ShowAsync();
            if (result == ContentDialogResult.Primary)
            {
                // TODO: let viewmodel of logged user call LogOut() method of AuthenticationService
                this.Frame.Navigate(typeof(Views.Aircrew.Login), null);
            }
        }
    }
}
