using Ifes.ViewModels.Passenger;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

namespace Ifes.Views.Passenger
{
    public sealed partial class Login : Page
    {
        private LoginViewModel _viewModel;

        public Login()
        {
            this.InitializeComponent();
            KeyboardAccelerator GoBack = new KeyboardAccelerator();
            GoBack.Key = Windows.System.VirtualKey.GoBack;
            GoBack.Invoked += BackInvoked;
            KeyboardAccelerator AltLeft = new KeyboardAccelerator();
            AltLeft.Key = Windows.System.VirtualKey.Left;
            AltLeft.Invoked += BackInvoked;
            this.KeyboardAccelerators.Add(GoBack);
            this.KeyboardAccelerators.Add(AltLeft);
            // ALT routes here
            AltLeft.Modifiers = Windows.System.VirtualKeyModifiers.Menu;

            this._viewModel = new LoginViewModel();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            BackButton.IsEnabled = this.Frame.CanGoBack;
        }

        private void OnBackClick(object sender, RoutedEventArgs e)
        {
            OnBackRequested();
        }

        // Handles system-level BackRequested events and page-level back button Click events
        private bool OnBackRequested()
        {
            if (this.Frame.CanGoBack)
            {
                this.Frame.Navigate(typeof(MainPage), null);
                return true;
            }
            return false;
        }

        private void BackInvoked(KeyboardAccelerator sender, KeyboardAcceleratorInvokedEventArgs args)
        {
            OnBackRequested();
            args.Handled = true;
        }

        private void OnClickBtnLogin(object sender, RoutedEventArgs e)
        {
            LoginUser();
        }

        private void OnKeyUp(object sender, KeyRoutedEventArgs e)
        {
            if (e.Key == Windows.System.VirtualKey.Enter && BtnLogin.IsEnabled)
            {
                LoginUser();
            }
        }

        private string GetReservationNumber()
        {
            return TextBoxReservationNumber.Text;
        }

        private void OnTextChanged(object sender, TextChangedEventArgs e)
        {
            ValidateLoginForm(GetReservationNumber());
        }

        private void ValidateLoginForm(string reservationNumber)
        {
            try
            {
                this._viewModel.ReservationNumber = reservationNumber;
                TextBoxReservationNumber.BorderBrush = new SolidColorBrush(Colors.White);
                BtnLogin.IsEnabled = true;
            }
            catch (Exception)
            {
                TextBoxReservationNumber.BorderBrush = new SolidColorBrush(Colors.Red);
                BtnLogin.IsEnabled = false;
            }
        }

        private void LoginUser()
        {
            try
            {
                TextBlockError.Text = "";
                this._viewModel.LogIn(GetReservationNumber());
                this.Frame.Navigate(typeof(Passenger.Dashboard), null);
            }
            catch (Exception ex)
            {
                TextBlockError.Text = ex.InnerException.Message;
                TextBoxReservationNumber.Focus(FocusState.Keyboard);
            }
        }
    }
}
