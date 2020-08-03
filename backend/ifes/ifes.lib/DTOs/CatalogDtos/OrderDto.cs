using ifes.lib.DTOs.PlaneDtos;
using ifes.lib.DTOs.UsersDtos;
using ifes.lib.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace ifes.lib.DTOs.CatalogDtos {
    public class OrderDto {
        public Guid Id { get; set; }
        public DateTime Created { get; set; }
        public OrderStatus Status { get; set; }
        public CatalogItemDto Item { get; set; }
        public PassengerDto Passenger { get; set; }
        public int Amount { get; set; }
    }
}
