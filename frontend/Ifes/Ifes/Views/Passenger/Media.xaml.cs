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
    public sealed partial class Media : Page
    {
        public Media() {
            this.InitializeComponent();
            NavigationViewControl.SelectedItem = NavigationViewControl.MenuItems.ElementAt(0);
            ContentFrame.Navigate(typeof(Views.Passenger.AudioVideoContentView), new AudioVideo("Movies", CatalogService.Instance.Movies));
        }

        private void NavViewItemInvoked(NavigationView sender, NavigationViewItemInvokedEventArgs args) {
            this.InitializeComponent();
            var label = args.InvokedItem as string;
            string title = label;
            IEnumerable<CatalogItem> items = null;
            if (label == "Movies") {
                items = CatalogService.Instance.Movies;
            } else if (label == "Audio") {
                items = CatalogService.Instance.Songs;
            }
            // else if (label == "TV Shows") {
            //    items = CatalogService.Instance.TvShows;
            //}
    ContentFrame.Navigate(typeof(Views.Passenger.AudioVideoContentView), new AudioVideo(title, items));
        }
    }
}
