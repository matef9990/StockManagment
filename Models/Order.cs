using System.ComponentModel.DataAnnotations.Schema;

namespace StockManagment.Models
{
    [Table("Orders")]
    public class Order
    {
        public int OrderId { get; set; }
        

        public double Price { get; set; }

        public int Quantity { get; set; }

        public decimal Commission { get; set; }

        public int StockId { get; set; }
        public Stock Stock { get; set; }

        public int PersonId { get; set; }
        public Person Person { get; set; }

        public int BrokerId { get; set; }
        public Broker Broker { get; set; }
    }
}
