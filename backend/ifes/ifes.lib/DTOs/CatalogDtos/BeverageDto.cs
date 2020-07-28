using ifes.lib.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace ifes.lib.DTOs.CatalogDtos {
   public class BeverageDto : CatalogItemDto {

        public BeverageType BeverageType { get; set; }
    }
}
