using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using ifes.lib.domain.Planes;
using ifes.lib.domain.Users;
using ifes.lib.Enum;

namespace ifes.lib.domain.Catalogs {
    public class Order {
        public Guid Id { get; set; }
        public DateTime Created { get; set; }
        public OrderStatus Status { get; set; }
        public Guid CatalogItemId { get; set; }
        public virtual CatalogItem Item { get; set; }
        public Passenger Passenger { get; set; }
        public Guid PlaneId { get; set; }

        public int Amount { get; set; }


    }
}