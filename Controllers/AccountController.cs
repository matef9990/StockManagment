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
    public class AccountController : ControllerBase
    {
        private readonly StocksDbContext _context;
        private readonly IStocksNotificationServices _stocksNotificationServices;
        public AccountController(StocksDbContext context,IStocksNotificationServices stocksNotificationServices)
        {
            _context = context;
            _stocksNotificationServices = stocksNotificationServices;

        }
        [HttpGet]
        public async Task<IEnumerable<Account>> GetAccounts()
        {
            return await _context.Accounts.ToListAsync();
        }

        [HttpPost]
        public async Task<IActionResult> NewAccount (Account account)
        {
            await _context.Accounts.AddAsync(account);

            try
            {
                await _context.SaveChangesAsync();
                await _stocksNotificationServices.NotifyRefreshCustomers();
                return Ok();
            }
            catch(Exception e)
            {
                return BadRequest(e);
            }
        }

    }
}