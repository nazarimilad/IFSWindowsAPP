using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using ifes.Controllers.Helpers;
using ifes.lib.domain.Catalogs;
using ifes.lib.domain.Planes;
using ifes.lib.domain.Users;
using ifes.lib.DTOs.CatalogDtos;
using ifes.lib.Enum;
using ifes.lib.Mappers;
using ifes.lib.Models.Catalogs;
using ifes.lib.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ifes.Controllers
{
    [Authorize(AuthenticationSchemes = "Bearer")]
    [Route("api/[controller]/[Action]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IRepository<Plane> _planeRepo;
        private readonly IRepository<CatalogItem> _catalogItemRepo;
        private readonly IRepository<Order> _orderRepo;
        private readonly IRepository<Passenger> _passengerRepo;
        private readonly OrderMapper _orderMapper;

        public OrderController(IRepository<Plane> planeRepo, IRepository<CatalogItem> catalogItemRepo,
            IRepository<Order> orderRepo, IRepository<Passenger> passengerRepo
            , OrderMapper orderMapper)
        {
            _planeRepo = planeRepo;
            _catalogItemRepo = catalogItemRepo;
            _orderRepo = orderRepo;
            _passengerRepo = passengerRepo;

            _orderMapper = orderMapper;
        }

        [HttpGet]
        public IActionResult GetPlaneOrders()
        {
            var orders = _orderRepo.Query(x => x.Status == OrderStatus.InProgress)
                .Include(x => x.Item)
                .Include(y => y.Passenger).ThenInclude(z => z.Seat).ToList();
            //var orderDtos = _orderMapper.MapOrdersDto(orders);
            return Ok(orders);
        }

        [HttpGet]
        public IActionResult GetPlaneOrdersDelivered()
        {
            var orders = _orderRepo.Query(x => x.Status == OrderStatus.Delivered)
                .Include(x => x.Item)
                .Include(y => y.Passenger).ThenInclude(z => z.Seat).ToList();
            //var orderDtos = _orderMapper.MapOrdersDto(orders);
            return Ok(orders);
        }

        [HttpGet]
        public IActionResult GetPassengerOrders([FromQuery] string passengerId)
        {
            var orders = getPassengerOrders(passengerId);
            //var orderDtos = _orderMapper.MapOrdersDto(orders);
            return Ok(orders);
        }
        
        [HttpGet]
        public IActionResult GetPassengerOrdersSpreadsheet([FromQuery] string passengerId, [FromQuery] string formatType)
        {
            if (formatType == "xls")
            {
                var orders = getPassengerOrders(passengerId);
                var workbook = SpreadsheetHelper.GenerateSpreadSheet(orders);
                string fileName = "orders_" + DateTime.Now.ToString("yyyy’-‘MM’-‘dd’T’HH’:’mm’:’ss.xls");
                using var fileStream = new FileStream(fileName, FileMode.Create);
                workbook.Write(fileStream);

                return File(fileStream, "application/octet-stream", fileName);
            }
            return BadRequest();
        }

        [HttpPut]
        public IActionResult PassengerOrder([FromBody] CatalogItemOrder orders)
        {
            var plane = _planeRepo.Query(x => true).Include(y => y.Seats).ThenInclude(a => a.Passenger)
                .FirstOrDefault();
            var passenger = plane.Seats.Where(x => x.Id == orders.SeatId).FirstOrDefault().Passenger;
            List<Order> newOrders = new List<Order>();
            orders.Items.ForEach(x =>
            {
                passenger.AddOrder(new Order()
                {
                    Created = DateTime.Now,
                    Item = _catalogItemRepo.Get(y => y.Id == x.Id),
                    Status = OrderStatus.InProgress,
                    Amount = x.Amount,
                    PlaneId = orders.PlaneId
                });
            });

            _passengerRepo.Update(passenger);
            _passengerRepo.SaveChanges();
            // var orderedItems = _orderMapper.MapOrdersDto(passenger.Orders);
            return Ok(passenger.Orders);
        }

        // PUT: api/Order/5
        [HttpPut]
        public void DeliverOrders([FromQuery] Guid orderId)
        {
            var pendingOrder = _orderRepo.Get(x => x.Id == orderId);
            pendingOrder.Status = OrderStatus.Delivered;
            _orderRepo.Update(pendingOrder);
            //var pendingOrders = _orderRepo.Query(x => x.Id != null).Where(x => orders.Contains(x.Id)).ToList();
            //pendingOrders.ForEach(x => {
            //    x.Status = OrderStatus.Delivered;
            //    _orderRepo.Update(x);

            //});
            _orderRepo.SaveChanges();
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }

        private IList<Order> getPassengerOrders(string passengerId)
        {
            return _orderRepo.Query(x => x.Passenger.Id == passengerId)
                            .Include(x => x.Item)
                            .ToList();
        }
    }
}