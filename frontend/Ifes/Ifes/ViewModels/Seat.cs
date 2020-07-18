using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ifes.ViewModels
{
    public class Seat
    {
        public string Id { get; private set; }
        public char Column { get; private set; }
        public int Row { get; private set; }
        public FlightClass FlightClass { get; private set; }

        public Seat(string id, char column, int row, FlightClass flightClass)
        {
            Id = id;
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
