using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ifes.ViewModels
{
    public abstract class CatalogItem
    {
        public string Id { get; private set; }
        public string Name { get; private set; }
        public double Price { get; private set; }
        public double PriceDiscounted
        {
            get { return Price - Discount; }
        }
        public double Discount { get; private set; }
        public PaymentOption PaymentOption { get; private set; }

        public CatalogItem(string id, string name, double price, double discount, PaymentOption paymentOption)
        {
            Id = id;
            Name = name;
            Price = price;
            Discount = discount;
            PaymentOption = paymentOption;
        }

        public override string ToString()
        {
            return $"{Name} ({PriceDiscounted})";
        }
    }
}
