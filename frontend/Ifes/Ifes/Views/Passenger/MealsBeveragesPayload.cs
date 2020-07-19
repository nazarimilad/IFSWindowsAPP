using Ifes.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ifes.Views.Passenger
{
    public class MealsBeveragesPayload
    {
        public string Title { get; set; }
        public IEnumerable<CatalogItem> Items;
    }
}
