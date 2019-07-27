using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StockManagment.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace StockManagment.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("_myAllowSpecificOrigins")]
    public class StocksController : ControllerBase
    {
        private readonly StocksDbContext _context;

        private readonly IStocksNotificationServices _marketNotificationServices;

        public StocksController(StocksDbContext context, IStocksNotificationServices marketNotificationServices)
        {
            _context = context;
            _marketNotificationServices = marketNotificationServices;
        }

        // GET: api/Stocks
        [HttpGet]
        public IEnumerable<Stock> GetStocks()
        {
            
            return _context.Stocks;
        }


        [HttpPatch]
        public async Task<IActionResult> PutStock()
        {

            var rdm = new Random();
            
            var stocks = _context.Stocks;
            foreach(var stock in stocks)
            {
                stock.Price = rdm.Next(1, 100);
                _context.Entry(stock).State = EntityState.Modified;
            }

            await _context.SaveChangesAsync();

            await _marketNotificationServices.NotifyRefreshStocks();

            return NoContent();
        }





    }
}