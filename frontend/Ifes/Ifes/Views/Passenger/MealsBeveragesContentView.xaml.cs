﻿using Ifes.ViewModels;
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
    public sealed partial class MealsBeveragesContentView : Page
    {
        public MealsBeverages MealsBeverages { get; set; }

        public MealsBeveragesContentView()
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
        private void TextBox_OnBeforeTextChanging(TextBox sender,
                                          TextBoxBeforeTextChangingEventArgs args) {
            args.Cancel = args.NewText.Any(c => !char.IsDigit(c));
        }
        private async void OnBtnOrderClick(object sender, RoutedEventArgs e)
        {
            ContentDialog confirmOrderAmount = new ContentDialog {
                Title = "Confirm order of : ",
                Content = $"{OrderAmount.Text} x {MealsBeverages.CurrentItem.Name}",

                PrimaryButtonText = "Confirm",
                CloseButtonText = "Cancel"
            };

            ContentDialogResult result = await confirmOrderAmount.ShowAsync();

            if (result == ContentDialogResult.Primary) {
                if (OrderAmount.Text != null) {

                    MealsBeverages.OrderCurrentItem(MealsBeverages.CurrentItem, Int16.Parse(OrderAmount.Text));
                    OrderAmount.Text = "";
                }
            } else {

            }

        }
    }
}
