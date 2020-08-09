using Ifes.Services;
using Ifes.ViewModels;
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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Ifes.Views.Aircrew {
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class OrdersView : Page {
        public OrdersView() {
            this.InitializeComponent();
            NavigationViewControl.SelectedItem = NavigationViewControl.MenuItems.ElementAt(0);
            ContentFrame.Navigate(typeof(Views.Aircrew.OrdersContentView), new OrderedItems("In Progress", OrderService.Instance.OrdersInProgress));
        }

        private void NavViewItemInvoked(NavigationView sender, NavigationViewItemInvokedEventArgs args) {
            var label = args.InvokedItem as string;
            string title = label;
            ObservableCollection<Order> items = null;
            if (label == "In Progress") {
                items = OrderService.Instance.OrdersInProgress;
            } else if (label == "Delivered") {
                items = OrderService.Instance.OrdersDelivered;
            }
            ContentFrame.Navigate(typeof(Views.Aircrew.OrdersContentView), new OrderedItems(title, items));
        }
    }
}