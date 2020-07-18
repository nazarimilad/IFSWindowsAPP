using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ifes.ViewModels
{
    public class Catalog
    {
        public IEnumerable<CatalogItem> Items { get; private set; }

        public Catalog()
        {
            Items = new List<CatalogItem>();
        }

        public Catalog(IEnumerable<CatalogItem> items)
        {
            Items = items;
        }
    }
}
