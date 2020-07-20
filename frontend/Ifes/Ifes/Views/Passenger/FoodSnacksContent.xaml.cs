using Ifes.ViewModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Ifes.Views.Passenger
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class FoodSnacksContent : Page
    {
        public MealsBeverages MealsBeverages { get; set; }

        public FoodSnacksContent()
        {
            this.InitializeComponent();
            TextBlockDescription.Text = "Please select an item for more details.";
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            MealsBeverages = (MealsBeverages) e.Parameter;
        }

        private void OnItemClick(object sender, ItemClickEventArgs e)
        {
            MealsBeverages.CurrentItem = (CatalogItem) e.ClickedItem;
            BtnOrder.IsEnabled = true;
        }

        private void OnBtnOrderClick(object sender, RoutedEventArgs e)
        {

        }
    }
}
