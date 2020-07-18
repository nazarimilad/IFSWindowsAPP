using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ifes.ViewModels
{
    public class Beverage : CatalogItem
    {
        public BeverageType BeverageType { get; private set; }

        public Beverage(string id, string name, double price, double discount, PaymentOption paymentOption, BeverageType beverateType) : base(id, name, price, discount, paymentOption)
        {
            BeverageType = beverateType;
        }
    }
}
