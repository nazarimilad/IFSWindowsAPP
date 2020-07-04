using ifes.lib.Enum;

namespace ifes.lib.domain {
    public class Food : CatalogItem {
        public int PreparationTime { get; set; }
        public FoodType FoodType { get; set; }
    }
}