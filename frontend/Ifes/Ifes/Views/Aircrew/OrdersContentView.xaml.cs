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

namespace Ifes.Views.Aircrew {
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class OrdersContentView : Page {
        public OrderedItems OrderedItems { get; set; }
        public OrdersContentView() {
            this.InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e) {
            base.OnNavigatedTo(e);
            OrderedItems = (OrderedItems)e.Parameter;
            if (OrderedItems.Title.ToLower() == "delivered") {
                BtnOrder.Visibility = Visibility.Collapsed;
            } else {
                BtnOrder.IsEnabled = true;
            }

        }

        private void OnItemClick(object sender, ItemClickEventArgs e) {
            OrderedItems.CurrentItem = (Order)e.ClickedItem;
            if(OrderedItems.Title.ToLower() == "delivered") {
                BtnOrder.Visibility = Visibility.Collapsed;
            } else {
                BtnOrder.IsEnabled = true;
            }
        }

        private void OnBtnDeliverClick(object sender, RoutedEventArgs e) {
            OrderedItems.DeliverOrder(OrderedItems.CurrentItem);
            this.InitializeComponent();

        }
    }
}

