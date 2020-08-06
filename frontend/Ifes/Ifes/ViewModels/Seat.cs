using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ifes.ViewModels
{
    public class Seat
    {
        public char Col { get; private set; }
        public int Row { get; private set; }
        public FlightClass FlightClass { get; private set; }

        public Seat(char column, int row, FlightClass flightClass)
        {
            Col = column;
            Row = row;
            FlightClass = flightClass;
        }

        public override string ToString()
        {
            return $"{Col}{Row}";
        }
    }
}
