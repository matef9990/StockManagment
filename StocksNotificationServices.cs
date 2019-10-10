using Microsoft.AspNetCore.SignalR;
using StockManagment.Models;
using System.Threading.Tasks;

namespace StockManagment
{
    public class StocksNotificationServices: IStocksNotificationServices
    {
        private readonly IHubContext<StocksHub> _stockHub;
        private readonly IHubContext<CustomerHub> _customerHub;
        private readonly StocksDbContext _stocksDbContext;
        public StocksNotificationServices(IHubContext<StocksHub> stockHub, IHubContext<CustomerHub> customerHub,StocksDbContext stocksDbContext)
        {
            this._stockHub = stockHub;
            this._customerHub = customerHub;
            this._stocksDbContext = stocksDbContext;
        }

        public async Task NotifyRefreshCustomers()
        {
            await _customerHub.Clients.All.SendAsync("CustomerList_Refreshed", _stocksDbContext.Accounts);
        }

        public async Task NotifyRefreshStocks()
        {
            await _stockHub.Clients.All.SendAsync("StocksList_Refreshed", _stocksDbContext.Stocks);
        }


        
    }
}
