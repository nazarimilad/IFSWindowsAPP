using ifes.lib.Enum;

namespace ifes.lib.domain.Catalogs {
    public class Food : CatalogItem {
        public int PreparationTime { get; set; }
        public FoodType FoodType { get; set; }
    }
}