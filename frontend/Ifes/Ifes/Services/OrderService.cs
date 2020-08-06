using Ifes.ViewModels;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Ifes.Services {
  public  class OrderService {


        private static readonly Lazy<OrderService> lazy = new Lazy<OrderService>(() => new OrderService());
        public static OrderService Instance { get { return lazy.Value; } }
        public IList<Order> Orders { get; set; }

        public OrderService() {
            Orders = new List<Order>();

            GetOrders();
        }

        private async void GetOrders() {
            var client = new HttpClient();
            var jsonOrders = await client.GetStringAsync(new Uri("https://localhost:44319/api/Order/GetPlaneOrders?planeId=3A824AE9-D070-46CE-84E5-2C46B68900A5", UriKind.Absolute));
            var dataOrders = JsonConvert.DeserializeObject<List<Order>>(jsonOrders);
            dataOrders.Sort((x, y) => DateTime.Compare(x.Created, y.Created));
            dataOrders.ForEach(x => Orders.Add(x));
        }
    }
}
