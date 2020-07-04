using System;
using ifes.lib.Enum;

namespace ifes.lib.domain {
    public class Order {
        public Guid Id { get; set; }
        public DateTime Created { get; set; }
        public OrderStatus Status { get; set; }
    }
}