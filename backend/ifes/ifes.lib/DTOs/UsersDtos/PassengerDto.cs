using ifes.lib.DTOs.CatalogDtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace ifes.lib.DTOs.UsersDtos {
    public class PassengerDto {
        public string UserName { get; set; }
        public string Id { get; set; }
        public string Token{ get; set; }
        //public string ReservationCode { get; set; }
        //public IEnumerable<OrderDto> Orders { get; set; }

    }
}
