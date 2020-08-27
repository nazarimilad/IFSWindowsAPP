using Ifes.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ifes.ViewModels
{
    public class MealsBeverages: INotifyPropertyChanged
    {
        public string Title { get; set; }
        public IEnumerable<CatalogItem> Items;
        private CatalogItem _currentItem;
        public CatalogItem CurrentItem
        {
            get { return _currentItem; }
            set
            {
                if (value != _currentItem)
                {
                    _currentItem = value;
                    NotifyPropertyChanged("CurrentItem");
                }
            }
        }

        public MealsBeverages(string title, IEnumerable<CatalogItem> items)
        {
            Title = title;
            Items = items;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged(String propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        internal void OrderCurrentItem(CatalogItem currentItem, int orderAmount) {
            var passenger = AuthenticationService.Instance.Passenger;
            OrderService.Instance.OrderItem(currentItem, orderAmount, passenger);
      }
    }
}
