using System;
using System.Collections.Generic;
using ifes.lib.Enum;

namespace ifes.lib.domain.Catalogs {
    public class Order {
        public Guid Id { get; set; }
        public DateTime Created { get; set; }
        public OrderStatus Status { get; set; }
        public List<CatalogItem> Items { get; set; }
    }
}