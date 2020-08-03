using ifes.lib.domain.Catalogs;
using System;
using System.Collections.Generic;
using System.Text;

namespace ifes.lib.Models.Catalogs {
    public class CatalogItemOrder {
        public Guid PlaneId { get; set; }
        public Guid SeatId { get; set; }
        public List<CatalogItems> Items { get; set; }
    }
    public class CatalogItems {
        public Guid Id { get; set; }
        public int Amount { get; set; }
    }
}
