using System.Collections.Generic;
using ifes.lib.domain.Catalogs;
using ifes.lib.Enum;

namespace ifes.lib.data {
    public class FoodInit {
        public static List<Food> getFoods() {
            var foods = new List<Food>();

            foods.Add(new Food {
                Description = "Banana Cake", Discount = 0, Name = "Banana Cake",
                Price = 5,

                FoodType = FoodType.Normal,
                PreparationTime = 9,
                PaymentOption = PaymentOption.Card
            });
            foods.Add(new Food {
                Description = "Blueberry Coffee Cake", Discount = 0, Name = "Blueberry Coffee Cake",
                Price = 1,

                FoodType = FoodType.Normal,
                PreparationTime = 9,
                PaymentOption = PaymentOption.Card
            });
            foods.Add(new Food {
                Description = "Chocolate Cake", Discount = 0, Name = "Chocolate Cake",
                Price = 2,

                FoodType = FoodType.Normal,
                PreparationTime = 7,
                PaymentOption = PaymentOption.Card
            });
            foods.Add(new Food {
                Description = "Chocolate Mayonaise Cake", Discount = 0, Name = "Chocolate Mayonaise Cake",
                Price = 4,

                FoodType = FoodType.Normal,
                PreparationTime = 1,
                PaymentOption = PaymentOption.Card
            });
            foods.Add(new Food {
                Description = "Crazy Cake", Discount = 0, Name = "Crazy Cake",
                Price = 4,

                FoodType = FoodType.Normal,
                PreparationTime = 9,
                PaymentOption = PaymentOption.Card
            });
            foods.Add(new Food {
                Description = "Fresh Apple Cake", Discount = 0, Name = "Fresh Apple Cake",
                Price = 8,

                FoodType = FoodType.Normal,
                PreparationTime = 8,
                PaymentOption = PaymentOption.Card
            });
            foods.Add(new Food {
                Description = "Fresh Pear Cake", Discount = 0, Name = "Fresh Pear Cake",
                Price = 0,

                FoodType = FoodType.Normal,
                PreparationTime = 3,
                PaymentOption = PaymentOption.Card
            });
            foods.Add(new Food {
                Description = "Graham Cracker Cake", Discount = 0, Name = "Graham Cracker Cake",
                Price = 5,

                FoodType = FoodType.Normal,
                PreparationTime = 8,
                PaymentOption = PaymentOption.Card
            });
            foods.Add(new Food {
                Description = "Hot Water Chocolate Cake", Discount = 0, Name = "Hot Water Chocolate Cake",
                Price = 4,

                FoodType = FoodType.Normal,
                PreparationTime = 5,
                PaymentOption = PaymentOption.Card
            });
            foods.Add(new Food {
                Description = "Hungry Bear Cheese Cake", Discount = 0, Name = "Hungry Bear Cheese Cake",
                Price = 6,

                FoodType = FoodType.Normal,
                PreparationTime = 5,
                PaymentOption = PaymentOption.Card
            });
            foods.Add(new Food {
                Description = "Lemon Poppy Cake", Discount = 0, Name = "Lemon Poppy Cake",
                Price = 1,

                FoodType = FoodType.Normal,
                PreparationTime = 1,
                PaymentOption = PaymentOption.Card
            });
            foods.Add(new Food {
                Description = "Light Old Fashioned Fruit Cake", Discount = 0, Name = "Light Old Fashioned Fruit Cake",
                Price = 6,

                FoodType = FoodType.Normal,
                PreparationTime = 7,
                PaymentOption = PaymentOption.Card
            });
            foods.Add(new Food {
                Description = "My Best Gingerbread", Discount = 0, Name = "My Best Gingerbread",
                Price = 9,

                FoodType = FoodType.Normal,
                PreparationTime = 4,
                PaymentOption = PaymentOption.Card
            });
            foods.Add(new Food {
                Description = "Oatmeal Cake", Discount = 0, Name = "Oatmeal Cake",
                Price = 0,

                FoodType = FoodType.Normal,
                PreparationTime = 8,
                PaymentOption = PaymentOption.Card
            });
            foods.Add(new Food {
                Description = "Orange Angel Food Cake", Discount = 0, Name = "Orange Angel Food Cake",
                Price = 6,

                FoodType = FoodType.Normal,
                PreparationTime = 6,
                PaymentOption = PaymentOption.Card
            });
            foods.Add(new Food {
                Description = "Orange-Poppy Seed Pound Cake", Discount = 0, Name = "Orange-Poppy Seed Pound Cake",
                Price = 5,

                FoodType = FoodType.Normal,
                PreparationTime = 7,
                PaymentOption = PaymentOption.Card
            });
            foods.Add(new Food {
                Description = "Pineapple Cake", Discount = 0, Name = "Pineapple Cake",
                Price = 7,

                FoodType = FoodType.Normal,
                PreparationTime = 3,
                PaymentOption = PaymentOption.Card
            });
            foods.Add(new Food {
                Description = "Pineapple-Carrot Cake*", Discount = 0, Name = "Pineapple-Carrot Cake*",
                Price = 3,

                FoodType = FoodType.Normal,
                PreparationTime = 8,
                PaymentOption = PaymentOption.Card
            });
            foods.Add(new Food {
                Description = "Potatoe Cake", Discount = 0, Name = "Potatoe Cake",
                Price = 2,

                FoodType = FoodType.Normal,
                PreparationTime = 9,
                PaymentOption = PaymentOption.Card
            });
            foods.Add(new Food {
                Description = "Pumpkin Swirl Cheesecake", Discount = 0, Name = "Pumpkin Swirl Cheesecake",
                Price = 3,

                FoodType = FoodType.Normal,
                PreparationTime = 3,
                PaymentOption = PaymentOption.Card
            });
            foods.Add(new Food {
                Description = "Refrigerator Cheesecake", Discount = 0, Name = "Refrigerator Cheesecake",
                Price = 6,

                FoodType = FoodType.Normal,
                PreparationTime = 2,
                PaymentOption = PaymentOption.Card
            });
            foods.Add(new Food {
                Description = "Sherry Wine Cake", Discount = 0, Name = "Sherry Wine Cake",
                Price = 3,

                FoodType = FoodType.Normal,
                PreparationTime = 1,
                PaymentOption = PaymentOption.Card
            });
            foods.Add(new Food {
                Description = "Special Prune Cake*", Discount = 0, Name = "Special Prune Cake*",
                Price = 1,

                FoodType = FoodType.Normal,
                PreparationTime = 9,
                PaymentOption = PaymentOption.Card
            });
            foods.Add(new Food {
                Description = "Spicy Fruit and Nut Cake*", Discount = 0, Name = "Spicy Fruit and Nut Cake*",
                Price = 9,

                FoodType = FoodType.Normal,
                PreparationTime = 3,
                PaymentOption = PaymentOption.Card
            });
            foods.Add(new Food {
                Description = "Strawberry Spice Loaf", Discount = 0, Name = "Strawberry Spice Loaf",
                Price = 4,

                FoodType = FoodType.Normal,
                PreparationTime = 0,
                PaymentOption = PaymentOption.Card
            });
            foods.Add(new Food {
                Description = "Three Layer Chocolate Mayonnaise Cake", Discount = 0,
                Name = "Three Layer Chocolate Mayonnaise Cake",
                Price = 2,

                FoodType = FoodType.Normal,
                PreparationTime = 4,
                PaymentOption = PaymentOption.Card
            });
            foods.Add(new Food {
                Description = "Two Layer Chocolate Mayonnaise Cake", Discount = 0,
                Name = "Two Layer Chocolate Mayonnaise Cake",
                Price = 4,

                FoodType = FoodType.Normal,
                PreparationTime = 9,
                PaymentOption = PaymentOption.Card
            });
            foods.Add(new Food {
                Description = "Upside Down Cake", Discount = 0, Name = "Upside Down Cake",
                Price = 0,

                FoodType = FoodType.Normal,
                PreparationTime = 7,
                PaymentOption = PaymentOption.Card
            });
            foods.Add(new Food {
                Description = "Blue Chip Cookies", Discount = 0, Name = "Blue Chip Cookies",
                Price = 8,

                FoodType = FoodType.Normal,
                PreparationTime = 3,
                PaymentOption = PaymentOption.Card
            });
            foods.Add(new Food {
                Description = "Bourbon Balls", Discount = 0, Name = "Bourbon Balls",
                Price = 5,

                FoodType = FoodType.Normal,
                PreparationTime = 2,
                PaymentOption = PaymentOption.Card
            });
            foods.Add(new Food {
                Description = "Chocolate Crisp Bran Cookies", Discount = 0, Name = "Chocolate Crisp Bran Cookies",
                Price = 0,

                FoodType = FoodType.Normal,
                PreparationTime = 10,
                PaymentOption = PaymentOption.Card
            });
            foods.Add(new Food {
                Description = "Chocolate Peanut Brunch Bars", Discount = 0, Name = "Chocolate Peanut Brunch Bars",
                Price = 8,

                FoodType = FoodType.Normal,
                PreparationTime = 1,
                PaymentOption = PaymentOption.Card
            });
            foods.Add(new Food {
                Description = "Chocolate Trio Squares*", Discount = 0, Name = "Chocolate Trio Squares*",
                Price = 2,

                FoodType = FoodType.Normal,
                PreparationTime = 6,
                PaymentOption = PaymentOption.Card
            });
            foods.Add(new Food {
                Description = "Christmas Logs", Discount = 0, Name = "Christmas Logs",
                Price = 9,

                FoodType = FoodType.Normal,
                PreparationTime = 3,
                PaymentOption = PaymentOption.Card
            });
            foods.Add(new Food {
                Description = "Christmas Snowballs", Discount = 0, Name = "Christmas Snowballs",
                Price = 7,

                FoodType = FoodType.Normal,
                PreparationTime = 9,
                PaymentOption = PaymentOption.Card
            });
            foods.Add(new Food {
                Description = "Crisp Oatmeal Fruit Strips", Discount = 0, Name = "Crisp Oatmeal Fruit Strips",
                Price = 7,

                FoodType = FoodType.Normal,
                PreparationTime = 4,
                PaymentOption = PaymentOption.Card
            });
            foods.Add(new Food {
                Description = "Frosted Delights", Discount = 0, Name = "Frosted Delights",
                Price = 5,

                FoodType = FoodType.Normal,
                PreparationTime = 0,
                PaymentOption = PaymentOption.Card
            });
            foods.Add(new Food {
                Description = "Ginger Snap Bars", Discount = 0, Name = "Ginger Snap Bars",
                Price = 8,

                FoodType = FoodType.Normal,
                PreparationTime = 3,
                PaymentOption = PaymentOption.Card
            });
            foods.Add(new Food {
                Description = " Ginger Snaps", Discount = 0, Name = " Ginger Snaps",
                Price = 5,

                FoodType = FoodType.Normal,
                PreparationTime = 8,
                PaymentOption = PaymentOption.Card
            });
            foods.Add(new Food {
                Description = "Honey Graham Crackers", Discount = 0, Name = "Honey Graham Crackers",
                Price = 5,

                FoodType = FoodType.Normal,
                PreparationTime = 7,
                PaymentOption = PaymentOption.Card
            });
            foods.Add(new Food {
                Description = "Jello Pastel Cookies", Discount = 0, Name = "Jello Pastel Cookies",
                Price = 3,

                FoodType = FoodType.Normal,
                PreparationTime = 3,
                PaymentOption = PaymentOption.Card
            });
            foods.Add(new Food {
                Description = "Lemon Squares", Discount = 0, Name = "Lemon Squares",
                Price = 4,

                FoodType = FoodType.Normal,
                PreparationTime = 7,
                PaymentOption = PaymentOption.Card
            });
            foods.Add(new Food {
                Description = "Minties", Discount = 0, Name = "Minties",
                Price = 4,

                FoodType = FoodType.Normal,
                PreparationTime = 4,
                PaymentOption = PaymentOption.Card
            });
            foods.Add(new Food {
                Description = "Oatmeal Cookies", Discount = 0, Name = "Oatmeal Cookies",
                Price = 8,

                FoodType = FoodType.Normal,
                PreparationTime = 6,
                PaymentOption = PaymentOption.Card
            });
            foods.Add(new Food {
                Description = "Oatmeal Fudge Bars*", Discount = 0, Name = "Oatmeal Fudge Bars*",
                Price = 8,

                FoodType = FoodType.Normal,
                PreparationTime = 5,
                PaymentOption = PaymentOption.Card
            });
            foods.Add(new Food {
                Description = "Peanut Butter Cookies", Discount = 0, Name = "Peanut Butter Cookies",
                Price = 4,

                FoodType = FoodType.Normal,
                PreparationTime = 6,
                PaymentOption = PaymentOption.Card
            });
            foods.Add(new Food {
                Description = "Pineapple Graham Bars", Discount = 0, Name = "Pineapple Graham Bars",
                Price = 9,

                FoodType = FoodType.Normal,
                PreparationTime = 2,
                PaymentOption = PaymentOption.Card
            });
            foods.Add(new Food {
                Description = "Prune Nut Bars", Discount = 0, Name = "Prune Nut Bars",
                Price = 3,

                FoodType = FoodType.Normal,
                PreparationTime = 7,
                PaymentOption = PaymentOption.Card
            });
            foods.Add(new Food {
                Description = "Pumpkin Oatmeal Cookies", Discount = 0, Name = "Pumpkin Oatmeal Cookies",
                Price = 4,

                FoodType = FoodType.Normal,
                PreparationTime = 6,
                PaymentOption = PaymentOption.Card
            });
            foods.Add(new Food {
                Description = "Snickerdoodles", Discount = 0, Name = "Snickerdoodles",
                Price = 3,

                FoodType = FoodType.Normal,
                PreparationTime = 2,
                PaymentOption = PaymentOption.Card
            });
            foods.Add(new Food {
                Description = "Soft Sugar Cookies", Discount = 0, Name = "Soft Sugar Cookies",
                Price = 1,

                FoodType = FoodType.Normal,
                PreparationTime = 0,
                PaymentOption = PaymentOption.Card
            });
            foods.Add(new Food {
                Description = "Thumbprint Cookies", Discount = 0, Name = "Thumbprint Cookies",
                Price = 4,

                FoodType = FoodType.Normal,
                PreparationTime = 1,
                PaymentOption = PaymentOption.Card
            });
            foods.Add(new Food {
                Description = "Walnut Squares", Discount = 0, Name = "Walnut Squares",
                Price = 6,

                FoodType = FoodType.Normal,
                PreparationTime = 4,
                PaymentOption = PaymentOption.Card
            });
            foods.Add(new Food {
                Description = "Banana Cream Pie", Discount = 0, Name = "Banana Cream Pie",
                Price = 2,

                FoodType = FoodType.Normal,
                PreparationTime = 4,
                PaymentOption = PaymentOption.Card
            });
            foods.Add(new Food {
                Description = "Blackberry Nectarine Pie", Discount = 0, Name = "Blackberry Nectarine Pie",
                Price = 0,

                FoodType = FoodType.Normal,
                PreparationTime = 2,
                PaymentOption = PaymentOption.Card
            });
            foods.Add(new Food {
                Description = "Creamy Apple Pie", Discount = 0, Name = "Creamy Apple Pie",
                Price = 2,

                FoodType = FoodType.Normal,
                PreparationTime = 4,
                PaymentOption = PaymentOption.Card
            });
            foods.Add(new Food {
                Description = "Dutch Apple Pie", Discount = 0, Name = "Dutch Apple Pie",
                Price = 2,

                FoodType = FoodType.Normal,
                PreparationTime = 5,
                PaymentOption = PaymentOption.Card
            });
            foods.Add(new Food {
                Description = "Fresh Strawberry Pie", Discount = 0, Name = "Fresh Strawberry Pie",
                Price = 2,

                FoodType = FoodType.Normal,
                PreparationTime = 1,
                PaymentOption = PaymentOption.Card
            });
            foods.Add(new Food {
                Description = "Lemon Cloud Pie", Discount = 0, Name = "Lemon Cloud Pie",
                Price = 9,

                FoodType = FoodType.Normal,
                PreparationTime = 1,
                PaymentOption = PaymentOption.Card
            });
            foods.Add(new Food {
                Description = "Lemon Luscious Pie", Discount = 0, Name = "Lemon Luscious Pie",
                Price = 6,

                FoodType = FoodType.Normal,
                PreparationTime = 10,
                PaymentOption = PaymentOption.Card
            });
            foods.Add(new Food {
                Description = "Lemon Meringue Pie", Discount = 0, Name = "Lemon Meringue Pie",
                Price = 6,

                FoodType = FoodType.Normal,
                PreparationTime = 4,
                PaymentOption = PaymentOption.Card
            });
            foods.Add(new Food {
                Description = "Old Fashioned Apple Pie", Discount = 0, Name = "Old Fashioned Apple Pie",
                Price = 9,

                FoodType = FoodType.Normal,
                PreparationTime = 8,
                PaymentOption = PaymentOption.Card
            });
            foods.Add(new Food {
                Description = "Peach Almond Pie", Discount = 0, Name = "Peach Almond Pie",
                Price = 1,

                FoodType = FoodType.Normal,
                PreparationTime = 9,
                PaymentOption = PaymentOption.Card
            });
            foods.Add(new Food {
                Description = "Peach Parfait Pie", Discount = 0, Name = "Peach Parfait Pie",
                Price = 6,

                FoodType = FoodType.Normal,
                PreparationTime = 9,
                PaymentOption = PaymentOption.Card
            });
            foods.Add(new Food {
                Description = "Peanut Butter Ice Cream Pie", Discount = 0, Name = "Peanut Butter Ice Cream Pie",
                Price = 4,

                FoodType = FoodType.Normal,
                PreparationTime = 3,
                PaymentOption = PaymentOption.Card
            });
            foods.Add(new Food {
                Description = "Peanut Butter Pie", Discount = 0, Name = "Peanut Butter Pie",
                Price = 3,

                FoodType = FoodType.Normal,
                PreparationTime = 7,
                PaymentOption = PaymentOption.Card
            });
            foods.Add(new Food {
                Description = "Pie Crust", Discount = 0, Name = "Pie Crust",
                Price = 1,

                FoodType = FoodType.Normal,
                PreparationTime = 2,
                PaymentOption = PaymentOption.Card
            });
            foods.Add(new Food {
                Description = "Sour Cream Raisin Pie", Discount = 0, Name = "Sour Cream Raisin Pie",
                Price = 9,

                FoodType = FoodType.Normal,
                PreparationTime = 5,
                PaymentOption = PaymentOption.Card
            });
            foods.Add(new Food {
                Description = "Walnut Pie", Discount = 0, Name = "Walnut Pie",
                Price = 10,

                FoodType = FoodType.Normal,
                PreparationTime = 7,
                PaymentOption = PaymentOption.Card
            });
            foods.Add(new Food {
                Description = "Walnut-Raisin pie", Discount = 0, Name = "Walnut-Raisin pie",
                Price = 5,

                FoodType = FoodType.Normal,
                PreparationTime = 5,
                PaymentOption = PaymentOption.Card
            });
            foods.Add(new Food {
                Description = "Angel Hash", Discount = 0, Name = "Angel Hash",
                Price = 8,

                FoodType = FoodType.Normal,
                PreparationTime = 3,
                PaymentOption = PaymentOption.Card
            });
            foods.Add(new Food {
                Description = "Blue Cheese Dressing", Discount = 0, Name = "Blue Cheese Dressing",
                Price = 5,

                FoodType = FoodType.Normal,
                PreparationTime = 2,
                PaymentOption = PaymentOption.Card
            });
            foods.Add(new Food {
                Description = "Broccoli Curry Salad", Discount = 0, Name = "Broccoli Curry Salad",
                Price = 3,

                FoodType = FoodType.Normal,
                PreparationTime = 5,
                PaymentOption = PaymentOption.Card
            });
            foods.Add(new Food {
                Description = "Broccoli Salad", Discount = 0, Name = "Broccoli Salad",
                Price = 7,

                FoodType = FoodType.Normal,
                PreparationTime = 1,
                PaymentOption = PaymentOption.Card
            });
            foods.Add(new Food {
                Description = "Broccoli Salad with Pineapple", Discount = 0, Name = "Broccoli Salad with Pineapple",
                Price = 3,

                FoodType = FoodType.Normal,
                PreparationTime = 10,
                PaymentOption = PaymentOption.Card
            });
            foods.Add(new Food {
                Description = "Carrot Carousel", Discount = 0, Name = "Carrot Carousel",
                Price = 7,

                FoodType = FoodType.Normal,
                PreparationTime = 9,
                PaymentOption = PaymentOption.Card
            });
            foods.Add(new Food {
                Description = "Coleslaw", Discount = 0, Name = "Coleslaw",
                Price = 1,

                FoodType = FoodType.Normal,
                PreparationTime = 7,
                PaymentOption = PaymentOption.Card
            });
            foods.Add(new Food {
                Description = "Cranberry Mold", Discount = 0, Name = "Cranberry Mold",
                Price = 7,

                FoodType = FoodType.Normal,
                PreparationTime = 7,
                PaymentOption = PaymentOption.Card
            });
            foods.Add(new Food {
                Description = "Cucumbers in Sour Cream", Discount = 0, Name = "Cucumbers in Sour Cream",
                Price = 7,

                FoodType = FoodType.Normal,
                PreparationTime = 3,
                PaymentOption = PaymentOption.Card
            });
            foods.Add(new Food {
                Description = "Five Bean Salad", Discount = 0, Name = "Five Bean Salad",
                Price = 6,

                FoodType = FoodType.Normal,
                PreparationTime = 2,
                PaymentOption = PaymentOption.Card
            });
            foods.Add(new Food {
                Description = "Five Cup Salad", Discount = 0, Name = "Five Cup Salad",
                Price = 9,

                FoodType = FoodType.Normal,
                PreparationTime = 3,
                PaymentOption = PaymentOption.Card
            });
            foods.Add(new Food {
                Description = "Garden Vegetable Pasta", Discount = 0, Name = "Garden Vegetable Pasta",
                Price = 7,

                FoodType = FoodType.Normal,
                PreparationTime = 4,
                PaymentOption = PaymentOption.Card
            });
            foods.Add(new Food {
                Description = "Green Bean Salad", Discount = 0, Name = "Green Bean Salad",
                Price = 5,

                FoodType = FoodType.Normal,
                PreparationTime = 1,
                PaymentOption = PaymentOption.Card
            });
            foods.Add(new Food {
                Description = "Heavenly Cheese Salad", Discount = 0, Name = "Heavenly Cheese Salad",
                Price = 9,

                FoodType = FoodType.Normal,
                PreparationTime = 10,
                PaymentOption = PaymentOption.Card
            });
            foods.Add(new Food {
                Description = "Horseradish Dressing", Discount = 0, Name = "Horseradish Dressing",
                Price = 4,

                FoodType = FoodType.Normal,
                PreparationTime = 6,
                PaymentOption = PaymentOption.Card
            });
            foods.Add(new Food {
                Description = "Lemon Cloud Salad", Discount = 0, Name = "Lemon Cloud Salad",
                Price = 4,

                FoodType = FoodType.Normal,
                PreparationTime = 8,
                PaymentOption = PaymentOption.Card
            });
            foods.Add(new Food {
                Description = "Lima Bean Salad", Discount = 0, Name = "Lima Bean Salad",
                Price = 3,

                FoodType = FoodType.Normal,
                PreparationTime = 0,
                PaymentOption = PaymentOption.Card
            });
            foods.Add(new Food {
                Description = "Pea Salad", Discount = 0, Name = "Pea Salad",
                Price = 3,

                FoodType = FoodType.Normal,
                PreparationTime = 0,
                PaymentOption = PaymentOption.Card
            });
            foods.Add(new Food {
                Description = "School French Dressing", Discount = 0, Name = "School French Dressing",
                Price = 8,

                FoodType = FoodType.Normal,
                PreparationTime = 7,
                PaymentOption = PaymentOption.Card
            });
            foods.Add(new Food {
                Description = "Spinach Salad", Discount = 0, Name = "Spinach Salad",
                Price = 5,

                FoodType = FoodType.Normal,
                PreparationTime = 8,
                PaymentOption = PaymentOption.Card
            });
            foods.Add(new Food {
                Description = "Spinach Salad with Avocado", Discount = 0, Name = "Spinach Salad with Avocado",
                Price = 9,

                FoodType = FoodType.Normal,
                PreparationTime = 7,
                PaymentOption = PaymentOption.Card
            });
            foods.Add(new Food {
                Description = "Spinach Salad with Alfalfa Sprouts", Discount = 0,
                Name = "Spinach Salad with Alfalfa Sprouts",
                Price = 0,

                FoodType = FoodType.Normal,
                PreparationTime = 2,
                PaymentOption = PaymentOption.Card
            });
            foods.Add(new Food {
                Description = "Summer Fruit Salad", Discount = 0, Name = "Summer Fruit Salad",
                Price = 3,

                FoodType = FoodType.Normal,
                PreparationTime = 10,
                PaymentOption = PaymentOption.Card
            });
            foods.Add(new Food {
                Description = "Top Ramen Salad", Discount = 0, Name = "Top Ramen Salad",
                Price = 5,

                FoodType = FoodType.Normal,
                PreparationTime = 6,
                PaymentOption = PaymentOption.Card
            });
            foods.Add(new Food {
                Description = "Zucchini Apple Slaw", Discount = 0, Name = "Zucchini Apple Slaw",
                Price = 6,

                FoodType = FoodType.Normal,
                PreparationTime = 3,
                PaymentOption = PaymentOption.Card
            });
            foods.Add(new Food {
                Description = "Broccoli Cheese Soup", Discount = 0, Name = "Broccoli Cheese Soup",
                Price = 10,

                FoodType = FoodType.Normal,
                PreparationTime = 6,
                PaymentOption = PaymentOption.Card
            });
            foods.Add(new Food {
                Description = "Chicken Noodle Soup", Discount = 0, Name = "Chicken Noodle Soup",
                Price = 10,

                FoodType = FoodType.Normal,
                PreparationTime = 3,
                PaymentOption = PaymentOption.Card
            });
            foods.Add(new Food {
                Description = "Cleo's Clam Chowder", Discount = 0, Name = "Cleo's Clam Chowder",
                Price = 0,

                FoodType = FoodType.Normal,
                PreparationTime = 2,
                PaymentOption = PaymentOption.Card
            });
            foods.Add(new Food {
                Description = "Creamy Zucchini Mushroom Soup", Discount = 0, Name = "Creamy Zucchini Mushroom Soup",
                Price = 8,

                FoodType = FoodType.Normal,
                PreparationTime = 1,
                PaymentOption = PaymentOption.Card
            });
            foods.Add(new Food {
                Description = "Elephant Stew", Discount = 0, Name = "Elephant Stew",
                Price = 6,

                FoodType = FoodType.Normal,
                PreparationTime = 9,
                PaymentOption = PaymentOption.Card
            });
            foods.Add(new Food {
                Description = "Hungry Bear Vegetable Soup", Discount = 0, Name = "Hungry Bear Vegetable Soup",
                Price = 7,

                FoodType = FoodType.Normal,
                PreparationTime = 7,
                PaymentOption = PaymentOption.Card
            });
            foods.Add(new Food {
                Description = "Mexican Meatball Soup", Discount = 0, Name = "Mexican Meatball Soup",
                Price = 1,

                FoodType = FoodType.Normal,
                PreparationTime = 2,
                PaymentOption = PaymentOption.Card
            });
            foods.Add(new Food {
                Description = "Minestrone Soup", Discount = 0, Name = "Minestrone Soup",
                Price = 3,

                FoodType = FoodType.Normal,
                PreparationTime = 8,
                PaymentOption = PaymentOption.Card
            });
            foods.Add(new Food {
                Description = "Tortilla Soup", Discount = 0, Name = "Tortilla Soup",
                Price = 2,

                FoodType = FoodType.Normal,
                PreparationTime = 5,
                PaymentOption = PaymentOption.Card
            });
            foods.Add(new Food {
                Description = "Chicken and Shrimp Cantonese", Discount = 0, Name = "Chicken and Shrimp Cantonese",
                Price = 8,

                FoodType = FoodType.Normal,
                PreparationTime = 2,
                PaymentOption = PaymentOption.Card
            });
            foods.Add(new Food {
                Description = "Chicken With Pineapple", Discount = 0, Name = "Chicken With Pineapple",
                Price = 2,

                FoodType = FoodType.Normal,
                PreparationTime = 5,
                PaymentOption = PaymentOption.Card
            });
            foods.Add(new Food {
                Description = "Chinese Beef", Discount = 0, Name = "Chinese Beef",
                Price = 5,

                FoodType = FoodType.Normal,
                PreparationTime = 8,
                PaymentOption = PaymentOption.Card
            });
            foods.Add(new Food {
                Description = "Chinese Broccoli", Discount = 0, Name = "Chinese Broccoli",
                Price = 9,

                FoodType = FoodType.Normal,
                PreparationTime = 6,
                PaymentOption = PaymentOption.Card
            });
            foods.Add(new Food {
                Description = "Chinese Chicken Salad", Discount = 0, Name = "Chinese Chicken Salad",
                Price = 10,

                FoodType = FoodType.Normal,
                PreparationTime = 3,
                PaymentOption = PaymentOption.Card
            });
            foods.Add(new Food {
                Description = "Chinese Fried Rice", Discount = 0, Name = "Chinese Fried Rice",
                Price = 7,

                FoodType = FoodType.Normal,
                PreparationTime = 5,
                PaymentOption = PaymentOption.Card
            });
            foods.Add(new Food {
                Description = "Chinese Pepper Steak", Discount = 0, Name = "Chinese Pepper Steak",
                Price = 3,

                FoodType = FoodType.Normal,
                PreparationTime = 8,
                PaymentOption = PaymentOption.Card
            });
            foods.Add(new Food {
                Description = "Chinese Roast Pork", Discount = 0, Name = "Chinese Roast Pork",
                Price = 0,

                FoodType = FoodType.Normal,
                PreparationTime = 0,
                PaymentOption = PaymentOption.Card
            });
            foods.Add(new Food {
                Description = "Chinese Stir Fried Chicken with Peanuts", Discount = 0,
                Name = "Chinese Stir Fried Chicken with Peanuts",
                Price = 2,

                FoodType = FoodType.Normal,
                PreparationTime = 3,
                PaymentOption = PaymentOption.Card
            });
            foods.Add(new Food {
                Description = "Scallops", Discount = 0, Name = "Scallops",
                Price = 8,

                FoodType = FoodType.Normal,
                PreparationTime = 2,
                PaymentOption = PaymentOption.Card
            });
            foods.Add(new Food {
                Description = "Cheese Fondue", Discount = 0, Name = "Cheese Fondue",
                Price = 8,

                FoodType = FoodType.Normal,
                PreparationTime = 2,
                PaymentOption = PaymentOption.Card
            });
            foods.Add(new Food {
                Description = "Golden Nugget Beef", Discount = 0, Name = "Golden Nugget Beef",
                Price = 2,

                FoodType = FoodType.Normal,
                PreparationTime = 5,
                PaymentOption = PaymentOption.Card
            });
            foods.Add(new Food {
                Description = "Baby Back Ribs", Discount = 0, Name = "Baby Back Ribs",
                Price = 6,

                FoodType = FoodType.Normal,
                PreparationTime = 6,
                PaymentOption = PaymentOption.Card
            });
            foods.Add(new Food {
                Description = "Sweet and Sour Meatballs", Discount = 0, Name = "Sweet and Sour Meatballs",
                Price = 2,

                FoodType = FoodType.Normal,
                PreparationTime = 3,
                PaymentOption = PaymentOption.Card
            });
            foods.Add(new Food {
                Description = "Saucy Shrimp Over Chinese Noodle Cakes", Discount = 0,
                Name = "Saucy Shrimp Over Chinese Noodle Cakes",
                Price = 0,

                FoodType = FoodType.Normal,
                PreparationTime = 7,
                PaymentOption = PaymentOption.Card
            });
            foods.Add(new Food {
                Description = "Sole Thermidor", Discount = 0, Name = "Sole Thermidor",
                Price = 8,

                FoodType = FoodType.Normal,
                PreparationTime = 3,
                PaymentOption = PaymentOption.Card
            });
            foods.Add(new Food {
                Description = "Bake Trout", Discount = 0, Name = "Bake Trout",
                Price = 10,

                FoodType = FoodType.Normal,
                PreparationTime = 9,
                PaymentOption = PaymentOption.Card
            });
            foods.Add(new Food {
                Description = "Cheesy Fish Fillets with Spinach", Discount = 0,
                Name = "Cheesy Fish Fillets with Spinach",
                Price = 6,

                FoodType = FoodType.Normal,
                PreparationTime = 9,
                PaymentOption = PaymentOption.Card
            });
            foods.Add(new Food {
                Description = "Cheese Fondue", Discount = 0, Name = "Cheese Fondue",
                Price = 1,

                FoodType = FoodType.Normal,
                PreparationTime = 5,
                PaymentOption = PaymentOption.Card
            });
            foods.Add(new Food {
                Description = "Sauteed Scallops", Discount = 0, Name = "Sauteed Scallops",
                Price = 0,

                FoodType = FoodType.Normal,
                PreparationTime = 0,
                PaymentOption = PaymentOption.Card
            });
            
            foods.Add(new Food {
                Description = "Sole Almondie", Discount = 0, Name = "Sole Almondie",
                Price = 7,

                FoodType = FoodType.Normal,
                PreparationTime = 8,
                PaymentOption = PaymentOption.Card
            });
            foods.Add(new Food {
                Description = "Hot Crab Dip", Discount = 0, Name = "Hot Crab Dip",
                Price = 8,

                FoodType = FoodType.Normal,
                PreparationTime = 9,
                PaymentOption = PaymentOption.Card
            });
            foods.Add(new Food {
                Description = "Shrimp Saute", Discount = 0, Name = "Shrimp Saute",
                Price = 8,

                FoodType = FoodType.Normal,
                PreparationTime = 2,
                PaymentOption = PaymentOption.Card
            });
            foods.Add(new Food {
                Description = "Sitr-Fry Beef and Broccoli", Discount = 0, Name = "Sitr-Fry Beef and Broccoli",
                Price = 5,

                FoodType = FoodType.Normal,
                PreparationTime = 7,
                PaymentOption = PaymentOption.Card
            });
            foods.Add(new Food {
                Description = "Barbecued Spareribs", Discount = 0, Name = "Barbecued Spareribs",
                Price = 9,

                FoodType = FoodType.Normal,
                PreparationTime = 3,
                PaymentOption = PaymentOption.Card
            });
            foods.Add(new Food {
                Description = "Sweet and Sour Pork", Discount = 0, Name = "Sweet and Sour Pork",
                Price = 9,

                FoodType = FoodType.Normal,
                PreparationTime = 7,
                PaymentOption = PaymentOption.Card
            });
            foods.Add(new Food {
                Description = "Beef Scallops with Fresh Tomato Sauce", Discount = 0,
                Name = "Beef Scallops with Fresh Tomato Sauce",
                Price = 5,

                FoodType = FoodType.Normal,
                PreparationTime = 5,
                PaymentOption = PaymentOption.Card
            });
            foods.Add(new Food {
                Description = "Veal Scallopini", Discount = 0, Name = "Veal Scallopini",
                Price = 5,

                FoodType = FoodType.Normal,
                PreparationTime = 0,
                PaymentOption = PaymentOption.Card
            });
            foods.Add(new Food {
                Description = "Savory Goulash", Discount = 0, Name = "Savory Goulash",
                Price = 4,

                FoodType = FoodType.Normal,
                PreparationTime = 7,
                PaymentOption = PaymentOption.Card
            });
            foods.Add(new Food {
                Description = "Veal Parmigan", Discount = 0, Name = "Veal Parmigan",
                Price = 5,

                FoodType = FoodType.Normal,
                PreparationTime = 3,
                PaymentOption = PaymentOption.Card
            });
            foods.Add(new Food {
                Description = "Teriyaki Steak", Discount = 0, Name = "Teriyaki Steak",
                Price = 10,

                FoodType = FoodType.Normal,
                PreparationTime = 3,
                PaymentOption = PaymentOption.Card
            });
            foods.Add(new Food {
                Description = "Beef Stroganoff", Discount = 0, Name = "Beef Stroganoff",
                Price = 6,

                FoodType = FoodType.Normal,
                PreparationTime = 3,
                PaymentOption = PaymentOption.Card
            });
            foods.Add(new Food {
                Description = "Hungry Bear Cheese Cake", Discount = 0, Name = "Hungry Bear Cheese Cake",
                Price = 6,

                FoodType = FoodType.Normal,
                PreparationTime = 4,
                PaymentOption = PaymentOption.Card
            });
            foods.Add(new Food {
                Description = "Egg Foo Young", Discount = 0, Name = "Egg Foo Young",
                Price = 9,

                FoodType = FoodType.Normal,
                PreparationTime = 3,
                PaymentOption = PaymentOption.Card
            });
            foods.Add(new Food {
                Description = "Egg Roll Filling", Discount = 0, Name = "Egg Roll Filling",
                Price = 3,

                FoodType = FoodType.Normal,
                PreparationTime = 8,
                PaymentOption = PaymentOption.Card
            });
            foods.Add(new Food {
                Description = "Egg Roll Wrappers", Discount = 0, Name = "Egg Roll Wrappers",
                Price = 1,

                FoodType = FoodType.Normal,
                PreparationTime = 4,
                PaymentOption = PaymentOption.Card
            });
            foods.Add(new Food {
                Description = "Pineapple Spareribs", Discount = 0, Name = "Pineapple Spareribs",
                Price = 7,

                FoodType = FoodType.Normal,
                PreparationTime = 2,
                PaymentOption = PaymentOption.Card
            });
            foods.Add(new Food {
                Description = "Pork Fu Man Chow", Discount = 0, Name = "Pork Fu Man Chow",
                Price = 3,

                FoodType = FoodType.Normal,
                PreparationTime = 7,
                PaymentOption = PaymentOption.Card
            });
            foods.Add(new Food {
                Description = "Shrimp Pineapple Fried Rice", Discount = 0, Name = "Shrimp Pineapple Fried Rice",
                Price = 9,

                FoodType = FoodType.Normal,
                PreparationTime = 1,
                PaymentOption = PaymentOption.Card
            });
            foods.Add(new Food {
                Description = "Sweet and Sour Pork", Discount = 0, Name = "Sweet and Sour Pork",
                Price = 0,

                FoodType = FoodType.Normal,
                PreparationTime = 9,
                PaymentOption = PaymentOption.Card
            });
            foods.Add(new Food {
                Description = "Albert's Chicken", Discount = 0, Name = "Albert's Chicken",
                Price = 8,

                FoodType = FoodType.Normal,
                PreparationTime = 3,
                PaymentOption = PaymentOption.Card
            });
            foods.Add(new Food {
                Description = "Avocado Chicken Melt", Discount = 0, Name = "Avocado Chicken Melt",
                Price = 5,

                FoodType = FoodType.Normal,
                PreparationTime = 4,
                PaymentOption = PaymentOption.Card
            });
            foods.Add(new Food {
                Description = "Batter Fried Chicken", Discount = 0, Name = "Batter Fried Chicken",
                Price = 1,

                FoodType = FoodType.Normal,
                PreparationTime = 2,
                PaymentOption = PaymentOption.Card
            });
            foods.Add(new Food {
                Description = "Catalina Chicken Stir Fry", Discount = 0, Name = "Catalina Chicken Stir Fry",
                Price = 4,

                FoodType = FoodType.Normal,
                PreparationTime = 9,
                PaymentOption = PaymentOption.Card
            });
            foods.Add(new Food {
                Description = "Chicken Breasts Florentine", Discount = 0, Name = "Chicken Breasts Florentine",
                Price = 8,

                FoodType = FoodType.Normal,
                PreparationTime = 4,
                PaymentOption = PaymentOption.Card
            });
            foods.Add(new Food {
                Description = "Chicken Cashew", Discount = 0, Name = "Chicken Cashew",
                Price = 1,

                FoodType = FoodType.Normal,
                PreparationTime = 8,
                PaymentOption = PaymentOption.Card
            });
            foods.Add(new Food {
                Description = "Chicken Lo Mein", Discount = 0, Name = "Chicken Lo Mein",
                Price = 1,

                FoodType = FoodType.Normal,
                PreparationTime = 9,
                PaymentOption = PaymentOption.Card
            });
            foods.Add(new Food {
                Description = "Chicken Paprika", Discount = 0, Name = "Chicken Paprika",
                Price = 10,

                FoodType = FoodType.Normal,
                PreparationTime = 9,
                PaymentOption = PaymentOption.Card
            });
            foods.Add(new Food {
                Description = "Chicken Schnitzel", Discount = 0, Name = "Chicken Schnitzel",
                Price = 7,

                FoodType = FoodType.Normal,
                PreparationTime = 3,
                PaymentOption = PaymentOption.Card
            });
            foods.Add(new Food {
                Description = "Chicken with Artichoke", Discount = 0, Name = "Chicken with Artichoke",
                Price = 7,

                FoodType = FoodType.Normal,
                PreparationTime = 5,
                PaymentOption = PaymentOption.Card
            });
            foods.Add(new Food {
                Description = "Coq au Vin", Discount = 0, Name = "Coq au Vin",
                Price = 7,

                FoodType = FoodType.Normal,
                PreparationTime = 1,
                PaymentOption = PaymentOption.Card
            });
            foods.Add(new Food {
                Description = "Creamy Chicken Broccoli with Rice", Discount = 0,
                Name = "Creamy Chicken Broccoli with Rice",
                Price = 2,

                FoodType = FoodType.Normal,
                PreparationTime = 8,
                PaymentOption = PaymentOption.Card
            });
            foods.Add(new Food {
                Description = "In a Hurry Chicken Curry", Discount = 0, Name = "In a Hurry Chicken Curry",
                Price = 1,

                FoodType = FoodType.Normal,
                PreparationTime = 9,
                PaymentOption = PaymentOption.Card
            });
            foods.Add(new Food {
                Description = "Jack Zucchini Chicken", Discount = 0, Name = "Jack Zucchini Chicken",
                Price = 1,

                FoodType = FoodType.Normal,
                PreparationTime = 7,
                PaymentOption = PaymentOption.Card
            });
            foods.Add(new Food {
                Description = "", Discount = 0, Name = "",
                Price = 0,

                FoodType = FoodType.Normal,
                PreparationTime = 3,
                PaymentOption = PaymentOption.Card
            });
            foods.Add(new Food {
                Description = "Maryland Fried Chicken", Discount = 0, Name = "Maryland Fried Chicken",
                Price = 6,

                FoodType = FoodType.Normal,
                PreparationTime = 3,
                PaymentOption = PaymentOption.Card
            });
            foods.Add(new Food {
                Description = "Oven Fried Chicken", Discount = 0, Name = "Oven Fried Chicken",
                Price = 9,

                FoodType = FoodType.Normal,
                PreparationTime = 8,
                PaymentOption = PaymentOption.Card
            });
            foods.Add(new Food {
                Description = "Parsley and Parmasen Baked Chicken", Discount = 0,
                Name = "Parsley and Parmasen Baked Chicken",
                Price = 9,

                FoodType = FoodType.Normal,
                PreparationTime = 4,
                PaymentOption = PaymentOption.Card
            });
          
            foods.Add(new Food {
                Description = "Saute'd Chicken Breats", Discount = 0, Name = "Saute'd Chicken Breats",
                Price = 8,

                FoodType = FoodType.Normal,
                PreparationTime = 3,
                PaymentOption = PaymentOption.Card
            });
            foods.Add(new Food {
                Description = "Saute'd Chicken Livers", Discount = 0, Name = "Saute'd Chicken Livers",
                Price = 10,

                FoodType = FoodType.Normal,
                PreparationTime = 7,
                PaymentOption = PaymentOption.Card
            });
            foods.Add(new Food {
                Description = "Spicy Singapore Wings", Discount = 0, Name = "Spicy Singapore Wings",
                Price = 1,

                FoodType = FoodType.Normal,
                PreparationTime = 5,
                PaymentOption = PaymentOption.Card
            });
            foods.Add(new Food {
                Description = "Turkey Tenderloin Supreme", Discount = 0, Name = "Turkey Tenderloin Supreme",
                Price = 1,

                FoodType = FoodType.Normal,
                PreparationTime = 8,
                PaymentOption = PaymentOption.Card
            });
            foods.Add(new Food {
                Description = "Asparagus Stir-Fried", Discount = 0, Name = "Asparagus Stir-Fried",
                Price = 10,

                FoodType = FoodType.Normal,
                PreparationTime = 9,
                PaymentOption = PaymentOption.Card
            });
            foods.Add(new Food {
                Description = "Baked Green Beans", Discount = 0, Name = "Baked Green Beans",
                Price = 6,

                FoodType = FoodType.Normal,
                PreparationTime = 3,
                PaymentOption = PaymentOption.Card
            });
            foods.Add(new Food {
                Description = "Baked Zucchini with Mushrooms", Discount = 0, Name = "Baked Zucchini with Mushrooms",
                Price = 7,

                FoodType = FoodType.Normal,
                PreparationTime = 2,
                PaymentOption = PaymentOption.Card
            });
            foods.Add(new Food {
                Description = "Bit O' Zucchini Bites", Discount = 0, Name = "Bit O' Zucchini Bites",
                Price = 5,

                FoodType = FoodType.Normal,
                PreparationTime = 7,
                PaymentOption = PaymentOption.Card
            });
            foods.Add(new Food {
                Description = "Cheesy Spinach Bake", Discount = 0, Name = "Cheesy Spinach Bake",
                Price = 1,

                FoodType = FoodType.Normal,
                PreparationTime = 4,
                PaymentOption = PaymentOption.Card
            });
            foods.Add(new Food {
                Description = "Company Cabbage", Discount = 0, Name = "Company Cabbage",
                Price = 2,

                FoodType = FoodType.Normal,
                PreparationTime = 4,
                PaymentOption = PaymentOption.Card
            });
            foods.Add(new Food {
                Description = "Crisp Potato Pancakes", Discount = 0, Name = "Crisp Potato Pancakes",
                Price = 4,

                FoodType = FoodType.Normal,
                PreparationTime = 1,
                PaymentOption = PaymentOption.Card
            });
            foods.Add(new Food {
                Description = "Easy Oven Baked Potatoes", Discount = 0, Name = "Easy Oven Baked Potatoes",
                Price = 3,

                FoodType = FoodType.Normal,
                PreparationTime = 8,
                PaymentOption = PaymentOption.Card
            });
            foods.Add(new Food {
                Description = "Eggplant Rollatini", Discount = 0, Name = "Eggplant Rollatini",
                Price = 6,

                FoodType = FoodType.Normal,
                PreparationTime = 6,
                PaymentOption = PaymentOption.Card
            });
            foods.Add(new Food {
                Description = "Glazed Carrots", Discount = 0, Name = "Glazed Carrots",
                Price = 3,

                FoodType = FoodType.Normal,
                PreparationTime = 10,
                PaymentOption = PaymentOption.Card
            });
            foods.Add(new Food {
                Description = "Green Beans Salerno", Discount = 0, Name = "Green Beans Salerno",
                Price = 8,

                FoodType = FoodType.Normal,
                PreparationTime = 1,
                PaymentOption = PaymentOption.Card
            });
            foods.Add(new Food {
                Description = "Italian Zucchini", Discount = 0, Name = "Italian Zucchini",
                Price = 3,

                FoodType = FoodType.Normal,
                PreparationTime = 8,
                PaymentOption = PaymentOption.Card
            });
            foods.Add(new Food {
                Description = "Mushrooms in Sour Cream", Discount = 0, Name = "Mushrooms in Sour Cream",
                Price = 5,

                FoodType = FoodType.Normal,
                PreparationTime = 6,
                PaymentOption = PaymentOption.Card
            });
            foods.Add(new Food {
                Description = "Orange Sweet Potatoes", Discount = 0, Name = "Orange Sweet Potatoes",
                Price = 9,

                FoodType = FoodType.Normal,
                PreparationTime = 1,
                PaymentOption = PaymentOption.Card
            });
            foods.Add(new Food {
                Description = "Peas", Discount = 0, Name = "Peas",
                Price = 2,

                FoodType = FoodType.Normal,
                PreparationTime = 2,
                PaymentOption = PaymentOption.Card
            });
            foods.Add(new Food {
                Description = "Saute Zucchini", Discount = 0, Name = "Saute Zucchini",
                Price = 5,

                FoodType = FoodType.Normal,
                PreparationTime = 9,
                PaymentOption = PaymentOption.Card
            });
            foods.Add(new Food {
                Description = "Spinach Pie", Discount = 0, Name = "Spinach Pie",
                Price = 9,

                FoodType = FoodType.Normal,
                PreparationTime = 7,
                PaymentOption = PaymentOption.Card
            });
            foods.Add(new Food {
                Description = "Spinach Souffle", Discount = 0, Name = "Spinach Souffle",
                Price = 9,

                FoodType = FoodType.Normal,
                PreparationTime = 3,
                PaymentOption = PaymentOption.Card
            });
            foods.Add(new Food {
                Description = "Spinach Strudels", Discount = 0, Name = "Spinach Strudels",
                Price = 4,

                FoodType = FoodType.Normal,
                PreparationTime = 7,
                PaymentOption = PaymentOption.Card
            });
            foods.Add(new Food {
                Description = "Stuffed Zucchini", Discount = 0, Name = "Stuffed Zucchini",
                Price = 3,

                FoodType = FoodType.Normal,
                PreparationTime = 0,
                PaymentOption = PaymentOption.Card
            });
            foods.Add(new Food {
                Description = "Summer Squash", Discount = 0, Name = "Summer Squash",
                Price = 0,

                FoodType = FoodType.Normal,
                PreparationTime = 3,
                PaymentOption = PaymentOption.Card
            });
            foods.Add(new Food {
                Description = "Sweet and Sour Red Cabbage", Discount = 0, Name = "Sweet and Sour Red Cabbage",
                Price = 3,

                FoodType = FoodType.Normal,
                PreparationTime = 10,
                PaymentOption = PaymentOption.Card
            });
            foods.Add(new Food {
                Description = "The Spinach", Discount = 0, Name = "The Spinach",
                Price = 5,

                FoodType = FoodType.Normal,
                PreparationTime = 4,
                PaymentOption = PaymentOption.Card
            });
            foods.Add(new Food {
                Description = "Three Cheese Spinach", Discount = 0, Name = "Three Cheese Spinach",
                Price = 7,

                FoodType = FoodType.Normal,
                PreparationTime = 8,
                PaymentOption = PaymentOption.Card
            });
            foods.Add(new Food {
                Description = "Tulelake Potato Casserole", Discount = 0, Name = "Tulelake Potato Casserole",
                Price = 5,

                FoodType = FoodType.Normal,
                PreparationTime = 7,
                PaymentOption = PaymentOption.Card
            });
            foods.Add(new Food {
                Description = "Zucchini Patties", Discount = 0, Name = "Zucchini Patties",
                Price = 7,

                FoodType = FoodType.Normal,
                PreparationTime = 8,
                PaymentOption = PaymentOption.Card
            });
            foods.Add(new Food {
                Description = "Apple Dumplings", Discount = 0, Name = "Apple Dumplings",
                Price = 10,

                FoodType = FoodType.Normal,
                PreparationTime = 5,
                PaymentOption = PaymentOption.Card
            });
            foods.Add(new Food {
                Description = "Apple Dessert for a Crowd", Discount = 0, Name = "Apple Dessert for a Crowd",
                Price = 2,

                FoodType = FoodType.Normal,
                PreparationTime = 6,
                PaymentOption = PaymentOption.Card
            });
            foods.Add(new Food {
                Description = "Chilled Prune Whip", Discount = 0, Name = "Chilled Prune Whip",
                Price = 9,

                FoodType = FoodType.Normal,
                PreparationTime = 3,
                PaymentOption = PaymentOption.Card
            });
            foods.Add(new Food {
                Description = "Fresh Peach Dessert", Discount = 0, Name = "Fresh Peach Dessert",
                Price = 6,

                FoodType = FoodType.Normal,
                PreparationTime = 10,
                PaymentOption = PaymentOption.Card
            });
            foods.Add(new Food {
                Description = "South Carolina Cobbler", Discount = 0, Name = "South Carolina Cobbler",
                Price = 1,

                FoodType = FoodType.Normal,
                PreparationTime = 3,
                PaymentOption = PaymentOption.Card
            });
            foods.Add(new Food {
                Description = "Spanish Cream Pudding", Discount = 0, Name = "Spanish Cream Pudding",
                Price = 1,

                FoodType = FoodType.Normal,
                PreparationTime = 7,
                PaymentOption = PaymentOption.Card
            });
            foods.Add(new Food {
                Description = "Artichoke-Mozzarella Casserole", Discount = 0, Name = "Artichoke-Mozzarella Casserole",
                Price = 6,

                FoodType = FoodType.Normal,
                PreparationTime = 2,
                PaymentOption = PaymentOption.Card
            });
            foods.Add(new Food {
                Description = "Asparagus Tomato Quiche", Discount = 0, Name = "Asparagus Tomato Quiche",
                Price = 9,

                FoodType = FoodType.Normal,
                PreparationTime = 6,
                PaymentOption = PaymentOption.Card
            });
            foods.Add(new Food {
                Description = "Beef Enchiladas", Discount = 0, Name = "Beef Enchiladas",
                Price = 4,

                FoodType = FoodType.Normal,
                PreparationTime = 7,
                PaymentOption = PaymentOption.Card
            });
            foods.Add(new Food {
                Description = "Beef Spinach Quiche", Discount = 0, Name = "Beef Spinach Quiche",
                Price = 5,

                FoodType = FoodType.Normal,
                PreparationTime = 7,
                PaymentOption = PaymentOption.Card
            });
            foods.Add(new Food {
                Description = "Broccoli and Rice Casserole", Discount = 0, Name = "Broccoli and Rice Casserole",
                Price = 2,

                FoodType = FoodType.Normal,
                PreparationTime = 7,
                PaymentOption = PaymentOption.Card
            });
            foods.Add(new Food {
                Description = "Broccoli Cheese Pie", Discount = 0, Name = "Broccoli Cheese Pie",
                Price = 2,

                FoodType = FoodType.Normal,
                PreparationTime = 6,
                PaymentOption = PaymentOption.Card
            });
            foods.Add(new Food {
                Description = "Cheese Strata", Discount = 0, Name = "Cheese Strata",
                Price = 6,

                FoodType = FoodType.Normal,
                PreparationTime = 9,
                PaymentOption = PaymentOption.Card
            });
            foods.Add(new Food {
                Description = "Chicken Tamale Pie", Discount = 0, Name = "Chicken Tamale Pie",
                Price = 10,

                FoodType = FoodType.Normal,
                PreparationTime = 3,
                PaymentOption = PaymentOption.Card
            });
            foods.Add(new Food {
                Description = "Chili Cheese Puff", Discount = 0, Name = "Chili Cheese Puff",
                Price = 4,

                FoodType = FoodType.Normal,
                PreparationTime = 9,
                PaymentOption = PaymentOption.Card
            });
            foods.Add(new Food {
                Description = "Chili Chicken", Discount = 0, Name = "Chili Chicken",
                Price = 7,

                FoodType = FoodType.Normal,
                PreparationTime = 4,
                PaymentOption = PaymentOption.Card
            });
            foods.Add(new Food {
                Description = "Chinese Noodle Casserole", Discount = 0, Name = "Chinese Noodle Casserole",
                Price = 3,

                FoodType = FoodType.Normal,
                PreparationTime = 9,
                PaymentOption = PaymentOption.Card
            });
            foods.Add(new Food {
                Description = "Crazy Crust Pizza", Discount = 0, Name = "Crazy Crust Pizza",
                Price = 7,

                FoodType = FoodType.Normal,
                PreparationTime = 3,
                PaymentOption = PaymentOption.Card
            });
            foods.Add(new Food {
                Description = "Deep Dish Pizza", Discount = 0, Name = "Deep Dish Pizza",
                Price = 8,

                FoodType = FoodType.Normal,
                PreparationTime = 10,
                PaymentOption = PaymentOption.Card
            });
            foods.Add(new Food {
                Description = "Easy Pasta Bake", Discount = 0, Name = "Easy Pasta Bake",
                Price = 6,

                FoodType = FoodType.Normal,
                PreparationTime = 3,
                PaymentOption = PaymentOption.Card
            });
            foods.Add(new Food {
                Description = "Fum Gum", Discount = 0, Name = "Fum Gum",
                Price = 7,

                FoodType = FoodType.Normal,
                PreparationTime = 9,
                PaymentOption = PaymentOption.Card
            });
            foods.Add(new Food {
                Description = "Garden Quiche", Discount = 0, Name = "Garden Quiche",
                Price = 3,

                FoodType = FoodType.Normal,
                PreparationTime = 5,
                PaymentOption = PaymentOption.Card
            });
            foods.Add(new Food {
                Description = "Impossible Taco Pie", Discount = 0, Name = "Impossible Taco Pie",
                Price = 1,

                FoodType = FoodType.Normal,
                PreparationTime = 3,
                PaymentOption = PaymentOption.Card
            });
            foods.Add(new Food {
                Description = "Pasta Primavera", Discount = 0, Name = "Pasta Primavera",
                Price = 10,

                FoodType = FoodType.Normal,
                PreparationTime = 3,
                PaymentOption = PaymentOption.Card
            });
            foods.Add(new Food {
                Description = "Ranch-style Baked Beans", Discount = 0, Name = "Ranch-style Baked Beans",
                Price = 9,

                FoodType = FoodType.Normal,
                PreparationTime = 7,
                PaymentOption = PaymentOption.Card
            });
            foods.Add(new Food {
                Description = "Savory Chicken Casserole", Discount = 0, Name = "Savory Chicken Casserole",
                Price = 2,

                FoodType = FoodType.Normal,
                PreparationTime = 8,
                PaymentOption = PaymentOption.Card
            });
            foods.Add(new Food {
                Description = "Sour Cream Enchiladas", Discount = 0, Name = "Sour Cream Enchiladas",
                Price = 3,

                FoodType = FoodType.Normal,
                PreparationTime = 5,
                PaymentOption = PaymentOption.Card
            });
            foods.Add(new Food {
                Description = "Spinach Fritatta", Discount = 0, Name = "Spinach Fritatta",
                Price = 6,

                FoodType = FoodType.Normal,
                PreparationTime = 7,
                PaymentOption = PaymentOption.Card
            });
            foods.Add(new Food {
                Description = "Stuffed Green Peppers", Discount = 0, Name = "Stuffed Green Peppers",
                Price = 9,

                FoodType = FoodType.Normal,
                PreparationTime = 4,
                PaymentOption = PaymentOption.Card
            });
            foods.Add(new Food {
                Description = "Tamale Pie", Discount = 0, Name = "Tamale Pie",
                Price = 10,

                FoodType = FoodType.Normal,
                PreparationTime = 8,
                PaymentOption = PaymentOption.Card
            });
            foods.Add(new Food {
                Description = "Tulelake Potato Casserole", Discount = 0, Name = "Tulelake Potato Casserole",
                Price = 8,

                FoodType = FoodType.Normal,
                PreparationTime = 6,
                PaymentOption = PaymentOption.Card
            });
            foods.Add(new Food {
                Description = "Wild Mushroom and Spinach Lasanga", Discount = 0,
                Name = "Wild Mushroom and Spinach Lasanga",
                Price = 7,

                FoodType = FoodType.Normal,
                PreparationTime = 1,
                PaymentOption = PaymentOption.Card
            });
            foods.Add(new Food {
                Description = "Zucchini Casserole", Discount = 0, Name = "Zucchini Casserole",
                Price = 7,

                FoodType = FoodType.Normal,
                PreparationTime = 4,
                PaymentOption = PaymentOption.Card
            });
            foods.Add(new Food {
                Description = "Zucchini-Ham Cheese Pie", Discount = 0, Name = "Zucchini-Ham Cheese Pie",
                Price = 3,

                FoodType = FoodType.Normal,
                PreparationTime = 9,
                PaymentOption = PaymentOption.Card
            });
            return foods;
        }
    }
}