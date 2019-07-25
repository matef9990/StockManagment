using StockManagment.Models;

namespace StockManagment.Controllers.Resources
{
    public class OrderResource
    {
        public int OrderId { get; set; }


        public double Price { get; set; }

        public int Quantity { get; set; }

        public decimal Commission { get; set; }

        public int StockId { get; set; }
        public Stock Stock { get; set; }

        public int? PersonId { get; set; }
        public PersonResource Person { get; set; }

        public int BrokerId { get; set; }
        public BrokerResource Broker { get; set; }
    }
}
