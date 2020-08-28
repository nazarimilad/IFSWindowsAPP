using System.Collections.Generic;
using ifes.lib.domain.Catalogs;

namespace ifes.lib.data {
    public class InitBeverage {
        public static List<Beverage> GetBeverages() {
            var beverages = new List<Beverage>();


            beverages.Add(new Beverage
            {

                BeverageType = Enum.BeverageType.Alcoholic,
                Name = "whisky",
                Price = 5.0,
                PaymentOption = Enum.PaymentOption.Card

            });


            return beverages;
        }
    }
}