using System;
using System.Collections.Generic;
using ifes.lib.Enum;

namespace ifes.lib.domain.Catalogs {
    public class Order {
        public Guid Id { get; set; }
        public DateTime Created { get; set; }
        public OrderStatus Status { get; set; }
        public CatalogItem Item { get; set; }
    }
}