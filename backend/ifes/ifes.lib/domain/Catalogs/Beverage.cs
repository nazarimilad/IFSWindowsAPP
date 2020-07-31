using ifes.lib.Enum;
using ifes.lib.Models.Catalogs.FoodAndBeverage;

namespace ifes.lib.domain.Catalogs {
    public class Beverage : CatalogItem {
        public BeverageType BeverageType { get; set; }

       public Beverage() {

        }
        public Beverage(AddBeverageModel model) {
            this.BeverageType = model.BeverageType;
            this.Description = model.Description;
            this.Discount = model.Discount;
            this.Name = model.Name;
            this.PaymentOption = model.PaymentOption;
            this.Price = model.Price;

        }
    }
}