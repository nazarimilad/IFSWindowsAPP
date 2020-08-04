﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ifes.lib.domain.Catalogs;
using ifes.lib.domain.Planes;
using ifes.lib.domain.Users;
using ifes.lib.Enum;
using ifes.lib.Mappers;
using ifes.lib.Models.Catalogs;
using ifes.lib.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ifes.Controllers {
    [Route("api/[controller]/[Action]")]
    [ApiController]
    public class OrderController : ControllerBase {
        private readonly IRepository<Plane> _planeRepo;
        private readonly IRepository<CatalogItem> _catalogItemRepo;
        private readonly IRepository<Order> _orderRepo;
        private readonly IRepository<Passenger> _passengerRepo;
        private readonly OrderMapper _orderMapper;

        public OrderController(IRepository<Plane> planeRepo, IRepository<CatalogItem> catalogItemRepo,IRepository<Order> orderRepo,IRepository<Passenger> passengerRepo
           , OrderMapper orderMapper) {
            _planeRepo = planeRepo;
            _catalogItemRepo = catalogItemRepo;
            _orderRepo = orderRepo;
            _passengerRepo = passengerRepo;

            _orderMapper = orderMapper;


        }

    // GET: api/Order
    [HttpGet]
    public IEnumerable<string> Get() {
        return new string[] { "value1", "value2" };
    }
        [HttpGet]
        public IActionResult GetPlaneOrders([FromQuery] Guid planeId) {

            var orders = _orderRepo.Query(x => x.PlaneId == planeId && x.Status == OrderStatus.InProgress)
                                    .Include(x => x.Item)
                                   .Include(y => y.Passenger).ThenInclude(z => z.Seat).ToList();
            var orderDtos = _orderMapper.MapOrdersDto(orders);
            return Ok(orderDtos);
        }

        [HttpPut]
    public IActionResult PassengerOrder([FromBody] CatalogItemOrder orders) {
            var plane = _planeRepo.Query(x => x.Id == orders.PlaneId).Include(y => y.Seats).ThenInclude(a => a.Passenger).FirstOrDefault();
            var passenger = plane.Seats.Where(x => x.Id == orders.SeatId).FirstOrDefault().Passenger;
            List<Order> newOrders = new List<Order>();
            orders.Items.ForEach(x => {
                passenger.AddOrder(new Order() {
                    Created = DateTime.Now,
                    Item = _catalogItemRepo.Get(y => y.Id == x.Id),
                    Status = OrderStatus.InProgress,
                    Amount = x.Amount,
                    PlaneId = orders.PlaneId
                }) ;
            });

            _passengerRepo.Update(passenger);
            _passengerRepo.SaveChanges();
            var orderedItems = _orderMapper.MapOrdersDto(passenger.Orders);
            return Ok(orderedItems);
    }

        // PUT: api/Order/5
        [HttpPut]
        public void DeliverOrders([FromBody] List<Guid> orders) {
            var pendingOrders = _orderRepo.Query(x => x.Id != null).Where(x => orders.Contains(x.Id)).ToList();
            pendingOrders.ForEach(x => {
                x.Status = OrderStatus.Delivered;
                _orderRepo.Update(x);

            });
            _orderRepo.SaveChanges();


        }

    // DELETE: api/ApiWithActions/5
    [HttpDelete("{id}")]
    public void Delete(int id) {
    }
}
}
