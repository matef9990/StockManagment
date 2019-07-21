namespace StockManagment
{
    public interface IMarketNotificationServices
    {
        System.Threading.Tasks.Task NotifyRefreshStocks();
    }
}