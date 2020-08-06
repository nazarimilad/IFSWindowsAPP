using Ifes.ViewModels;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Ifes.Services {
    public sealed class CatalogService {
        private static readonly Lazy<CatalogService> lazy = new Lazy<CatalogService>(() => new CatalogService());

        public static CatalogService Instance { get { return lazy.Value; } }

        public IEnumerable<CatalogItem> Catalog { get; private set; }
        public IList<Food> Meals { get; set; }
        public IList<Beverage> Beverages { get; set; }
        public IList<Media> Movies { get; set; }
       // public IList<Media> TvShows { get; set; }
        public IList<Media> Songs { get; set; }

        private CatalogService()
        {
            Meals = new List<Food>();
            Beverages = new List<Beverage>();
            Movies = new List<Media>();
            //TvShows = new List<Media>();
            Songs = new List<Media>();
            GetCatalog();
        }
        private async void GetCatalog()
        {
            var client = new HttpClient();
            var jsonFood = await client.GetStringAsync(new Uri("https://localhost:44319/api/Food/Get", UriKind.Absolute));
            var dataFood = JsonConvert.DeserializeObject<List<Food>>(jsonFood);
            var jsonBev = await client.GetStringAsync(new Uri("https://localhost:44319/api/Beverage/Get", UriKind.Absolute));
            var dataBev = JsonConvert.DeserializeObject<List<Beverage>>(jsonBev);
            var jsonAudio = await client.GetStringAsync(new Uri("https://localhost:44319/api/Audio/Get", UriKind.Absolute));
            var dataAudio = JsonConvert.DeserializeObject<List<Media>>(jsonAudio);
            var jsonVideo = await client.GetStringAsync(new Uri("https://localhost:44319/api/Video/Get", UriKind.Absolute));
            var dataVideo = JsonConvert.DeserializeObject<List<Media>>(jsonVideo);

            dataFood.ForEach(x => Meals.Add(x));
            dataBev.ForEach(x => Beverages.Add(x));
            dataAudio.ForEach(x => Songs.Add(x));
            dataVideo.ForEach(x => Movies.Add(x));


            // TODO: make http request and deserialise JSON result into corresponding view model
            //return new List<CatalogItem>()
            //{
            //    // food
            //    new Food("Baked Spaghetti",
            //             "Nothing beats a heaping helping of spaghetti.",
            //             5.90,
            //             0,
            //             PaymentOption.Card,
            //             1200,
            //             FoodType.Normal),
            //    new Food("Air Fryer Pork Chops",
            //             "That parmesan coating really gives it an extra oomph",
            //             8.50,
            //             0.20,
            //             PaymentOption.Card,
            //             1500,
            //             FoodType.Normal),
            //    new Food("Easy Cajun Jambalaya",
            //             "This dish will transport you straight to the French quarter.",
            //             6.30,
            //             0,
            //             PaymentOption.Card,
            //             1100,
            //             FoodType.Vegan),
            //    // beverages
            //    new Beverage("Coco-Cola",
            //                 "Refresh the World. Make a Difference",
            //                 2.50,
            //                 0.0,
            //                 PaymentOption.Card,
            //                 BeverageType.SoftDrinks),
            //    new Beverage("Coffee",
            //                 "We believe that coffee is more than just a drink: It’s a culture, an economy, an art, a science — and a passion.",
            //                 2.30,
            //                 0.0,
            //                 PaymentOption.Card,
            //                 BeverageType.HotDrinks),
            //    new Beverage("Mint Thee",
            //                 "Refreshing mint tea is exactly what you need when the weather is too warm for a traditional cuppa but slightly too cool for an iced tea.",
            //                 2.30,
            //                 0.0,
            //                 PaymentOption.Card,
            //                 BeverageType.HotDrinks),
            //    new Beverage("Kilbeggan Traditional Irish Whiskey",
            //                 "Named after the distillery of the same name dating back to 1757, Kilbeggan is an elegant, sweet and malty blend.",
            //                 7.10,
            //                 0.0,
            //                 PaymentOption.Card,
            //                 BeverageType.Alcoholic),
            //    // movies
            //    new Media("Parasite (2019)",
            //              "Greed and class discrimination threaten the newly formed symbiotic relationship between the wealthy Park family and the destitute Kim clan.",
            //              3.99,
            //              0.0,
            //              PaymentOption.Card,
            //              MediaType.Movie,
            //              7920,
            //              "qJA983nLijqzd893A"),
            //    new Media("The Irishman (2019)",
            //              "An old man recalls his time painting houses for his friend, Jimmy Hoffa, through the 1950-70s.",
            //              3.99,
            //              0.0,
            //              PaymentOption.Card,
            //              MediaType.Movie,
            //              12540,
            //              "qJA983nLccn452ijqzd"),
            //    new Media("Portrait of a Lady on Fire (2019)",
            //              "On an isolated island in Brittany at the end of the eighteenth century, a female painter is obliged to paint a wedding portrait of a young woman.",
            //              3.99,
            //              0.0,
            //              PaymentOption.Card,
            //              MediaType.Movie,
            //              7320,
            //              "aJA983nLccn452ijqzd"),
            //    // tv shows
            //    new Media("Breaking Bad (2008)",
            //              "A high school chemistry teacher diagnosed with inoperable lung cancer turns to manufacturing and selling methamphetamine in order to secure his family's future.",
            //              4.99,
            //              0.0,
            //              PaymentOption.Card,
            //              MediaType.TvShow,
            //              2940,
            //              "bJA983nLccn452ijqzd"),
            //    new Media("Chernobyl (2019)",
            //              "In April 1986, an explosion at the Chernobyl nuclear power plant in the Union of Soviet Socialist Republics becomes one of the world's worst man-made catastrophes.",
            //              4.99,
            //              0.0,
            //              PaymentOption.Card,
            //              MediaType.TvShow,
            //              3900,
            //              "cJA983nLccn452ijqzd"),
            //    new Media("Mr. Robot (2015)",
            //              "Elliot, a brilliant but highly unstable young cyber-security engineer and vigilante hacker, becomes a key figure in a complex game of global dominance " +
            //              "when he and his shadowy allies try to take down the corrupt corporation he works for. ",
            //              4.99,
            //              0.0,
            //              PaymentOption.Card,
            //              MediaType.TvShow,
            //              2940,
            //              "dJA983nLccn452ijqzd"),
            //    // songs
            //    new Media("Sinnerman",
            //              "Nina simone",
            //              1.99,
            //              0.0,
            //              PaymentOption.Card,
            //              MediaType.Song,
            //              619,
            //              "eJA983nLccn452ijqzd"),
            //    new Media("Elements",
            //              "Joyhauser",
            //              1.99,
            //              0.0,
            //              PaymentOption.Card,
            //              MediaType.Song,
            //              285,
            //              "fJA983nLccn452ijqzd"),
            //    new Media("Let Me Down Easy",
            //              "Paolo Nutini",
            //              1.99,
            //              0.0,
            //              PaymentOption.Card,
            //              MediaType.Song,
            //              285,
            //              "gJA983nLccn452ijqzd"),

            //};
        }
    }
}
