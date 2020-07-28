using ifes.lib.DTOs.CatalogDtos;
using ifes.lib.DTOs.UsersDtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace ifes.lib.DTOs.PlaneDtos {
    public class PlaneDto {
        public Guid Id { get; set; }
        public string TailNumber { get; set; }


        public IEnumerable<SeatDto> Seats { get; set; }
        public IEnumerable<OrderDto> Orders { get; set; }
        public IEnumerable<CabinCrewDto> CabinCrew { get; set; }
    }
}
