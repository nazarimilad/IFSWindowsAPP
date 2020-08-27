using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ifes.ViewModels
{
    public class Order
    {
        public Guid Id { get; set; }
        public DateTime Created { get; private set; }
        public OrderStatus Status { get; private set; }
        public int Amount { get; set; }
        public ItemInOrder Item { get;  set; }
        [JsonProperty("passenger")]
        public Passenger Passenger { get; private set; }

        public Order(DateTime created, OrderStatus status, ItemInOrder item, Passenger passenger)
        {
            Created = created;
            Status = status;
            Item = item;
            Passenger = passenger;

        }

        public override string ToString()
        {
            return $"{Item}: {Status}";
        }
        public string HourMinutesCreated() {
            return Created.ToString("HH:mm");
        }
        public string PassengerAndSeat() {
            return $"{Passenger.UserName} : {Passenger.Seat.Col}{Passenger.Seat.Row}";
        }
    }
    public class ItemInOrder {
        public string Name { get; private set; }
        public string Description { get; private set; }
        public double Price { get; private set; }
        public double PriceDiscounted {
            get { return Price - Discount; }
        }
        public double Discount { get; private set; }

        public ItemInOrder(string name, string description, double price, double discount) {
            this.Name = name;
            this.Description = description;
            this.Price = price;
            this.Discount = discount;
        }

        public override string ToString() {
            return $"{Name} ({PriceDiscounted})";
        }
    }
}
