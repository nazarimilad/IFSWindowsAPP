using Ifes.Services.Aircrew;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ifes.ViewModels.Aircrew
{
    class LoginViewModel : INotifyPropertyChanged
    {
        private string _email;
        private string _password;
        private const int MIN_LENGTH_PASSWORD = 6;

        public string Email
        {
            get { return _email; }
            set
            {
                if (!IsValidEmail(value))
                {
                    throw new Exception("E-mail is not valid.");
                }
                else if (value != _email)
                {
                    _email = value;
                    NotifyPropertyChanged("Email");
                }
            }
        }
        public string Password
        {
            get { return _password; }
            set
            {
                if (!IsValidPassword(value))
                {
                    throw new Exception("Password is not valid.");
                }
                if (value != _password)
                {
                    _password = value;
                    NotifyPropertyChanged("Password");
                }
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged(String propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        public bool IsValidPassword(string password)
        {
            return password.Length >= MIN_LENGTH_PASSWORD;
        }

        public void LogIn(string email, string password)
        {
            try
            {
                bool isLoggedIn = AuthenticationService.Instance.LogIn(email, password).Result;
            }
            catch (Exception) {
                throw;
            }
        }
    }
}
