using ifes.lib.Enum;
using ifes.lib.Models.Catalogs.FoodAndBeverage;

namespace ifes.lib.domain.Catalogs {
    public class Food : CatalogItem {
        public int PreparationTime { get; set; }
        public FoodType FoodType { get; set; }

        public Food() {

        }
        public Food(AddFoodModel model) {
            this.Description = model.Description;
            this.Discount = model.Discount;
            this.FoodType = model.FoodType;
            this.Name = model.Name;
            this.PaymentOption = model.PaymentOption;
            this.PreparationTime = model.PreparationTime;
            this.Price = model.Price;

        }
    }
}