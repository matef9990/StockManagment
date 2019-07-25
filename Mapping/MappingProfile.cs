using AutoMapper;
using StockManagment.Controllers.Resources;
using StockManagment.Models;

namespace StockManagment.Mapping
{
    public class MappingProfile :Profile
    {
        public MappingProfile()
        {
            CreateMap<Order, OrderResource>();
            CreateMap<Person, PersonResource>();
            CreateMap<Broker, BrokerResource>();
        }
    }
}
