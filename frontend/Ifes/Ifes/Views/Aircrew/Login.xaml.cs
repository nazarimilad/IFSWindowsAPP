using Ifes.ViewModels.Aircrew;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
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

        private string GetEmail()
        {
            return TextBoxEmail.Text;
        }

        private string GetPassword()
        {
            return PasswordBoxPassword.Password.ToString();
        }

        private void OnBtnLogin(object sender, RoutedEventArgs e)
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

        private void LoginUser()
        {
            try
            {
                TextBlockError.Text = "";
                this._viewModel.LogIn(GetEmail(), GetPassword());
                this.Frame.Navigate(typeof(Aircrew.Dashboard), null);
            }
            catch (Exception ex)
            {
                TextBlockError.Text = ex.InnerException.Message;
                TextBoxEmail.Focus(FocusState.Keyboard);
            }
        }

        private void OnChangeTextEmail(object sender, TextChangedEventArgs e)
        {
            ValidateLoginForm(GetEmail(), GetPassword());
        }

        private void OnChangeTextPassword(object sender, RoutedEventArgs e)
        {
            ValidateLoginForm(GetEmail(), GetPassword());
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
