using Microsoft.AspNetCore.SignalR;
using StockManagment.Models;
using System.Threading.Tasks;

namespace StockManagment
{
    public class StocksNotificationServices: IStocksNotificationServices
    {
        private readonly IHubContext<StocksHub> _stockHub;
        private readonly StocksDbContext _stocksDbContext;
        public StocksNotificationServices(IHubContext<StocksHub> stockHub, StocksDbContext stocksDbContext)
        {
            this._stockHub = stockHub;
            this._stocksDbContext = stocksDbContext;
        }

        public async Task NotifyRefreshStocks()
        {
            await _stockHub.Clients.All.SendAsync("StocksList_Refreshed", _stocksDbContext.Stocks);
        }

    }
}
