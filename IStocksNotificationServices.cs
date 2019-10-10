using System.Threading.Tasks;

namespace StockManagment
{
    public interface IStocksNotificationServices
    {
        Task NotifyRefreshStocks();
        Task NotifyRefreshCustomers();

    }
}