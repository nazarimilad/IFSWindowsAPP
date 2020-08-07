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

namespace Ifes.Services {
    public class OrderService {


        private static readonly Lazy<OrderService> lazy = new Lazy<OrderService>(() => new OrderService());
        public static OrderService Instance { get { return lazy.Value; } }
        public ObservableCollection<Order> Orders { get; set; }


        public OrderService() {
            Orders = new ObservableCollection<Order>();

            GetOrders();
        }

        private async void GetOrders() {
            var client = new HttpClient();
            var jsonOrders = await client.GetStringAsync(new Uri("https://localhost:44319/api/Order/GetPlaneOrders?planeId=3A824AE9-D070-46CE-84E5-2C46B68900A5", UriKind.Absolute));
            var dataOrders = JsonConvert.DeserializeObject<List<Order>>(jsonOrders);
            dataOrders.Sort((x, y) => DateTime.Compare(x.Created, y.Created));
            dataOrders.ForEach(x => Orders.Add(x));
        }
        public async void DeliverOrder(Order order) {
            var client = new HttpClient();

            var deliver = await client.PutAsync(new Uri("https://localhost:44319/api/Order/DeliverOrders?orderId=" + order.Id), null);
            if (deliver.IsSuccessStatusCode) Orders.Remove(order);
        }
        public async void OrderItem(CatalogItem item, int orderAmount) {
            var client = new HttpClient();
            var items = new List<OrderedItemsDto>();
            items.Add(new OrderedItemsDto() { Id = item.Id, Amount = orderAmount });

            var order = new OrderItemDto() {
                PlaneId = new Guid("3A824AE9-D070-46CE-84E5-2C46B68900A5"),
                SeatId = new Guid("79825DD9-DACA-49A3-8AF7-FB0481910A8E"),
                Items = items,
            };
            string output = JsonConvert.SerializeObject(order);
            var content = new StringContent(output, Encoding.UTF8, "application/json");
            var uri = new Uri("https://localhost:44319/api/Order/PassengerOrder");

            var deliver = await client.PutAsync(uri, content);
            if (deliver.IsSuccessStatusCode) GetOrders();

        }
    }
}
