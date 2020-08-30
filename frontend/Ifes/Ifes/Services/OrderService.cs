using Ifes.ViewModels;
using Ifes.ViewModels.ApiRequest;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using Ifes.Helpers;

namespace Ifes.Services {
    public class OrderService {


        private static readonly Lazy<OrderService> lazy = new Lazy<OrderService>(() => new OrderService());
        public static OrderService Instance { get { return lazy.Value; } }
        public ObservableCollection<Order> OrdersInProgress { get; set; }
        public ObservableCollection<Order> OrdersDelivered { get; set; }
        public ObservableCollection<Order> PassengerOrders { get; set; }


        public OrderService() {
            OrdersInProgress = new ObservableCollection<Order>();
            OrdersDelivered = new ObservableCollection<Order>();
            PassengerOrders = new ObservableCollection<Order>();


            GetOrdersInProgress();
            GetDeliveredOrders();
            GetPassengerOrders();
        }

        private async void GetOrdersInProgress() {
            using (var client = HttpClientWithToken.GetClient()) {
                var jsonOrders = await client.GetStringAsync(new Uri("https://localhost:44319/api/Order/GetPlaneOrders?planeId=26A6CE9B-D178-4C87-1CAA-08D84C339A85", UriKind.Absolute));
                var dataOrders = JsonConvert.DeserializeObject<List<Order>>(jsonOrders);
                dataOrders.Sort((x, y) => DateTime.Compare(x.Created, y.Created));
                dataOrders.ForEach(x => OrdersInProgress.Add(x));
            }
        }
        private async void GetDeliveredOrders() {
            using (var client = HttpClientWithToken.GetClient()) {
                var jsonOrders = await client.GetStringAsync(new Uri("https://localhost:44319/api/Order/GetPlaneOrdersDelivered?planeId=26A6CE9B-D178-4C87-1CAA-08D84C339A85", UriKind.Absolute));
                var dataOrders = JsonConvert.DeserializeObject<List<Order>>(jsonOrders);
                dataOrders.Sort((x, y) => DateTime.Compare(x.Created, y.Created));
                dataOrders.ForEach(x => OrdersDelivered.Add(x));
            }
        }
        public async void GetPassengerOrders() {
            if (AuthenticationService.Instance.Passenger == null)
            {
                return;
            }
            var passengerId = AuthenticationService.Instance.Passenger.Id;

            if (passengerId == null) return ;
            using (var client = HttpClientWithToken.GetClient()) {
                var jsonOrders = await client.GetStringAsync(new Uri("https://localhost:44319/api/Order/GetPassengerOrders?passengerId=" + $"{passengerId}", UriKind.Absolute));
                var dataOrders = JsonConvert.DeserializeObject<List<Order>>(jsonOrders);
                dataOrders.Sort((x, y) => DateTime.Compare(y.Created, x.Created));
                PassengerOrders.Clear();
                dataOrders.ForEach(x => PassengerOrders.Add(x));
            }

        }



        public async void DeliverOrder(Order order) {
            using (var client = HttpClientWithToken.GetClient()) {

                var deliver = await client.PutAsync(new Uri("https://localhost:44319/api/Order/DeliverOrders?orderId=" + order.Id), null);
                if (deliver.IsSuccessStatusCode) {
                    OrdersInProgress.Remove(order);
                    OrdersDelivered.Add(order);

                }
            }
        }
        public async void OrderItem(CatalogItem item, int orderAmount, Passenger passenger) {

            using (var client = HttpClientWithToken.GetClient()) {
                var items = new List<OrderedItemsDto>();
            items.Add(new OrderedItemsDto() { Id = item.Id, Amount = orderAmount });

            var order = new OrderItemDto() {
                PlaneId = passenger.PlaneId,//new Guid("3A824AE9-D070-46CE-84E5-2C46B68900A5"),
                SeatId = passenger.Seat.Id,//new Guid("79825DD9-DACA-49A3-8AF7-FB0481910A8E"),
                Items = items,
            };
            string output = JsonConvert.SerializeObject(order);
            var content = new StringContent(output, Encoding.UTF8, "application/json");
            var uri = new Uri("https://localhost:44319/api/Order/PassengerOrder");

            var deliver = await client.PutAsync(uri, content);
                if (deliver.IsSuccessStatusCode) {
                    GetOrdersInProgress();
                    GetPassengerOrders();
                }
        }

        }

    }
}
