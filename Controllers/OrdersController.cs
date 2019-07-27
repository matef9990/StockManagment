using AutoMapper;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StockManagment.Controllers.Resources;
using StockManagment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StockManagment.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("_myAllowSpecificOrigins")]

    public class OrdersController : Controller
    {
        private readonly StocksDbContext _context;
        private readonly IMapper _mapper;

        public OrdersController(StocksDbContext context,IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        // GET: api/Orders
        [HttpGet]
        public async Task<IEnumerable<OrderResource>> GetOrders()
        {
            var orders = await _context.Orders.Include(s => s.Stock).Include(p => p.Person).Include(b => b.Broker).ToListAsync();
            return _mapper.Map<List<Order>, List<OrderResource>>(orders);
        }



        [HttpPost]
        public async Task<IActionResult>PostRandomelyOrders()
        {
            Order order;
            var stocksIds = _context.Stocks.Select(si => si.StockId).ToArray();
            var rdm = new Random();
            for(int i=0;i<10;i++)
            {
                var sId = rdm.Next(stocksIds.Min(), stocksIds.Max());
                var Stock = _context.Stocks.SingleOrDefault(s => s.StockId ==sId);
                var pId = rdm.Next(1, 4);
                var person = _context.People.SingleOrDefault(p => p.PersonId == pId);
                var commission = person == null ? 2 : 1;
                order = new Order()
                {
                    StockId = sId,
                    Stock = Stock,
                    Price = Stock.Price,
                    Quantity = rdm.Next(1, 200),
                    BrokerId = 2,
                    Commission = commission,
                    Person = person

                };
                _context.Orders.Add(order);
                await _context.SaveChangesAsync();
            }

            return Ok();

        }

    }
}