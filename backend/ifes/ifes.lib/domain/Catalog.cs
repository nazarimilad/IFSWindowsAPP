using System;
using System.Collections.Generic;

namespace ifes.lib.domain {
    public class Catalog {
        public Guid Id { get; set; }
        public IEnumerable<CatalogItem> Items { get; set; }
        
    }
}