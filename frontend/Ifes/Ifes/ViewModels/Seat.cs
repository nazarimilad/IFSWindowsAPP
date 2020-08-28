using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ifes.ViewModels
{
    public class Seat
    {
        public Guid Id { get; set; }
        [JsonProperty("col")]
        public string Col { get; set; }
        public int Row { get; set; }
        public FlightClass FlightClass { get; set; }
        [JsonProperty("passenger")]
        public Passenger Passenger { get; set; }
        public Seat(string column, int row, FlightClass flightClass)
        {
            Col = column;
            Row = row;
            FlightClass = flightClass;
        }

        public Seat()
        {

        }

        public string RenderText
        {
            get
            {
                if (this.Col !="" )
                {
                    return $"{Col}{Row}";
                }
                return "";
            }
        }


        public string RenderBackground
        {
            get
            {
                if (this.Col != "")
                {
                    return $"#4295f5";
                }
                return "#fff";
            }
        }

        public override string ToString()
        {
            return $"{Col}{Row}";
        }
    }
}
