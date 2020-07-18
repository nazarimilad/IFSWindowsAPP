using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ifes.ViewModels
{
    public class Order
    {
        public DateTime DateTime { get; private set; }
        public OrderStatus Status { get; private set; }
        public CatalogItem Item { get; private set; }

        public Order(DateTime dateTime, OrderStatus status, CatalogItem item)
        {
            DateTime = dateTime;
            Status = status;
            Item = item;
        }

        public override string ToString()
        {
            return $"{Item}: {Status}";
        }
    }
}
