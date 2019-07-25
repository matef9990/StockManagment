using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace StockManagment.Controllers.Resources
{
    public class BrokerResource
    {
        public int BrokerId { get; set; }

        public string Name { get; set; }

        public ICollection<PersonResource> People { get; set; }

        public BrokerResource()
        {
            People = new Collection<PersonResource>();

        }
    }
}
