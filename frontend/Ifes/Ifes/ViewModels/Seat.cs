using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ifes.ViewModels
{
    public class Seat
    {
        public char Column { get; private set; }
        public int Row { get; private set; }
        public FlightClass FlightClass { get; private set; }

        public Seat(char column, int row, FlightClass flightClass)
        {
            Column = column;
            Row = row;
            FlightClass = flightClass;
        }

        public override string ToString()
        {
            return $"{Column}{Row}";
        }
    }
}
