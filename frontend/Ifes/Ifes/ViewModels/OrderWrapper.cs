using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ifes.ViewModels {
    public class OrderWrapper {
        public Order Order { get; set; }
    }
    public class OrdersWrapper{
        public IEnumerable<OrderWrapper> Orders { get; set; }
    }

}
