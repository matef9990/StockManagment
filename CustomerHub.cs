using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;

namespace StockManagment
{
    [EnableCors("_myAllowSpecificOrigins")]
    public class CustomerHub :Hub
    {
        public async Task JoinCustomers()
        {
            await Groups.AddToGroupAsync(this.Context.ConnectionId, "Customers");
        }
    }
}
