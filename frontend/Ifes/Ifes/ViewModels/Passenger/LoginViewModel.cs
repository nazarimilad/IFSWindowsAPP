﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using Ifes.Services.Passengers;

namespace Ifes.ViewModels.Passenger
{
    class LoginViewModel
    {
        private Regex _regex = new Regex("^[a-zA-Z0-9]{4,20}$");
        private string _reservationNumber;
        public string ReservationNumber
        {
            get { return _reservationNumber; }
            set
            {
                if (!IsValidReservationNumber(value))
                {
                    throw new Exception("Reservation number is not valid.");
                }
                _reservationNumber = value;
            }
        }

        public bool IsValidReservationNumber(string reservationNumber)
        {
            return _regex.IsMatch(reservationNumber);
        }

        public void LogIn(string reservationNumber)
        {
            try
            {
                bool isLoggedIn = AuthenticationService.Instance.LogIn(reservationNumber).Result;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}