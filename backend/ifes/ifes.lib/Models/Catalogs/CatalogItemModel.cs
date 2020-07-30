using ifes.lib.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace ifes.lib.Models.Catalogs {
    public abstract class CatalogItemModel {
        public string Name { get; set; }
        public string Description { get; set; }
        public double Discount { get; set; }
        public double Price { get; set; }
        public PaymentOption PaymentOption { get; set; }
    }
}
