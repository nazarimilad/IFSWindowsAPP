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

        }
    }
}
