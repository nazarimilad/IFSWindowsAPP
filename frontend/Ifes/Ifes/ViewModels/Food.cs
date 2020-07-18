using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ifes.ViewModels
{
    public class Food : CatalogItem
    {
        public int PreparationTime { get; private set; }
        public FoodType FoodType { get; private set; }

        public Food(string name, string description, double price, double discount, PaymentOption paymentOption, int preparationTime, FoodType foodType) : 
            base(name, description, price, discount, paymentOption)
        {
            PreparationTime = preparationTime;
            FoodType = foodType;
        }
    }
}
