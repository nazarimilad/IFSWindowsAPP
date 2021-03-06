﻿using System;
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

namespace Ifes.Views
{
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void OnClickBtnAircrew(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Views.Aircrew.Login), null);
        }

        private void OnClickBtnPassenger(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Views.Passenger.Login), null);
        }
    }
}
