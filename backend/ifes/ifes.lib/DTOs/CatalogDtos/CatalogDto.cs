using System;
using System.Collections.Generic;
using System.Text;

namespace ifes.lib.DTOs.CatalogDtos {
    public class CatalogDto {
        public Guid Id { get; set; }
        public IEnumerable<CatalogItemDto> Items { get; set; }
    }
}
