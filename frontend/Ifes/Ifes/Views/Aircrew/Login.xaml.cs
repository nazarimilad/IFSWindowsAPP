using Ifes.ViewModels.Aircrew;
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

namespace Ifes.Aircrew
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

        private void OnBtnLogin(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Aircrew.Dashboard), null);
        }

        private void OnChangeTextEmail(object sender, TextChangedEventArgs e)
        {
            ValidateLoginForm(TextBoxEmail.Text, PasswordBoxPassword.Password.ToString());
        }

        private void ValidateLoginForm(string email, string password)
        {
            try
            {
                this._viewModel.Email = email;
                this._viewModel.Password = password;
                TextBoxEmail.BorderBrush = new SolidColorBrush(Colors.White);
                BtnLogin.IsEnabled = true;
            }
            catch (Exception)
            {
                TextBoxEmail.BorderBrush = new SolidColorBrush(Colors.Red);
                BtnLogin.IsEnabled = false;
            }
        }
    }
}
