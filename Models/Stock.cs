using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StockManagment.Models
{
    [Table("Stocks")]
    public class Stock
    {
        public int StockId { get; set; }

        [Required]
        public string Name { get; set; }

        public double Price { get; set; }
    }
}