using Ifes.Services;
using Ifes.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
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

namespace Ifes.Views.Passenger
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Orders : Page
    {
        public OrderedItems OrderedItems { get; set; }
        public Orders() {
            this.InitializeComponent();
            NavigationViewControl.SelectedItem = NavigationViewControl.MenuItems.ElementAt(0);
            var passengerId = AuthenticationService.Instance.Passenger.Id;
            ContentFrame.Navigate(typeof(Views.Passenger.MyOrdersView), new OrderedItems("My Orders",OrderService.Instance.PassengerOrders));
        }

        private void NavViewItemInvoked(NavigationView sender, NavigationViewItemInvokedEventArgs args) {
            var label = args.InvokedItem as string;
            string title = label;
            ObservableCollection<Order> items = null;
            if (label == "My Orders") {
                items = OrderService.Instance.PassengerOrders;

            }
            ContentFrame.Navigate(typeof(Views.Passenger.MyOrdersView), new OrderedItems(title, items));
        }
    }
}