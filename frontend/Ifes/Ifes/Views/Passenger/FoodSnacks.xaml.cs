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
    public sealed partial class FoodSnacks : Page
    {
        public FoodSnacks()
        {
            this.InitializeComponent();
            NavigationViewControl.SelectedItem = NavigationViewControl.MenuItems.ElementAt(0);
            ContentFrame.Navigate(typeof(Views.Passenger.FoodSnacksContent), new MealsBeveragesPayload { Title = "Meals", Items = CatalogService.Instance.Beverages });
        }

        private void NavViewItemInvoked(NavigationView sender, NavigationViewItemInvokedEventArgs args)
        {
            var label = args.InvokedItem as string;
            string title = label;
            IEnumerable<CatalogItem> items = null;
            if (label == "Meals")
            {
                items = CatalogService.Instance.Meals;
            }
            else if (label == "Beverages")
            {
                items = CatalogService.Instance.Beverages;
            }
            ContentFrame.Navigate(typeof(Views.Passenger.FoodSnacksContent), new MealsBeveragesPayload { Title = title, Items = items });
        }
    }
}
