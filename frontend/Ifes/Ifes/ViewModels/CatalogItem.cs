using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ifes.ViewModels
{
    public abstract class CatalogItem
    {
        public Guid Id { get; set; }
        public string Name { get; private set; }
        public string Description { get; private set; }
        public double Price { get; private set; }
        public double PriceDiscounted
        {
            get { return Price - Discount; }
        }
        public double Discount { get; private set; }
        public PaymentOption PaymentOption { get; private set; }

        public CatalogItem(string name, string description, double price, double discount, PaymentOption paymentOption)
        {
            Name = name;
            Description = description;
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
