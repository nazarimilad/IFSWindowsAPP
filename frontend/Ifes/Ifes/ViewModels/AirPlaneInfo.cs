using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ifes.ViewModels
{
    public class AirPlaneInfo
    {
        public string TailNumber { get; private set; }
        public int MaxAmountSeats { get; private set; }
        public string CompanyName { get; private set; }
        public string Manufacturer { get; private set; }
        public string Model { get; private set; }

        public AirPlaneInfo(string tailNumber, int maxAmountSeats, string companyName, string manufacturer, string model)
        {
            TailNumber = tailNumber;
            MaxAmountSeats = maxAmountSeats;
            CompanyName = companyName;
            Manufacturer = manufacturer;
            Model = model;
        }
    }
}
