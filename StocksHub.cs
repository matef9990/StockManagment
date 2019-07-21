using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;

namespace StockManagment
{
    [EnableCors("_myAllowSpecificOrigins")]
    public class StocksHub :Hub
    {
        public async Task JoinMarket()
        {
            await Groups.AddToGroupAsync(this.Context.ConnectionId,"Market");
        }
    }
}
