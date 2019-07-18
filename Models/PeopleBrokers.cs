namespace StockManagment.Models
{
    public class PeopleBrokers
    {
        public int PersonId { get; set; }
        public Person Person { get; set; }

        public int BrokerId { get; set; }
        public Broker Broker { get; set; }
    }
}
