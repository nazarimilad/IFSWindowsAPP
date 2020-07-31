using ifes.lib.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace ifes.lib.Models.Catalogs.FoodAndBeverage {
    public class AddFoodModel :CatalogItemModel{
        public int PreparationTime { get; private set; }
        public FoodType FoodType { get; private set; }
    }
}
