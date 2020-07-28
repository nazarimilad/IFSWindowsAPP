using System;
using ifes.lib.Enum;

namespace ifes.lib.domain.Catalogs {
    public abstract class CatalogItem {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Discount { get; set; }
        public double Price { get; set; }
        public PaymentOption PaymentOption { get; set; }

    }
}