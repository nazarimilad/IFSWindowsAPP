using ifes.lib.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace ifes.lib.DTOs.CatalogDtos {
   public class FoodDto : CatalogItemDto {

        public int PreparationTime { get; set; }
        public FoodType FoodType { get; set; }
    }
}
