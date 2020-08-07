using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ifes.ViewModels.ApiRequest {
   public  class OrderItemDto {
        public Guid PlaneId { get; set; }
        public Guid SeatId { get; set; }
        public List<OrderedItemsDto> Items { get; set; } = new List<OrderedItemsDto>();
    }
    public class OrderedItemsDto {
        public Guid Id { get; set; }
        public int Amount { get; set; }
    }
}
