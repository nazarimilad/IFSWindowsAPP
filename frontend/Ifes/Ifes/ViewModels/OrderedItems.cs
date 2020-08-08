using Ifes.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ifes.ViewModels {
    public class OrderedItems {
        public string Title { get; set; }
        public IEnumerable<Order> Items;
        private Order _currentItem;

        public Order CurrentItem {
            get { return _currentItem; }
            set {
                if (value != _currentItem) {
                    _currentItem = value;
                    NotifyPropertyChanged("CurrentItem");
                }
            }
        }

        public OrderedItems(string title, IEnumerable<Order> items) {
            Title = title;
            Items = items;
        }
        public void DeliverOrder(Order order) {
            OrderService.Instance.DeliverOrder(order);

        }
        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged(String propertyName) {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
