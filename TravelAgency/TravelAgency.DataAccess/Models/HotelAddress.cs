using TravelAgency.BusinessLogic.Models;

namespace TravelAgency.DataAccess.Models
{
    public class HotelAddress:BaseEntity
    {
        public string Name { get; set; }
        public string Country { get; set; }

        public string City { get; set; }

        public string Street { get; set; }
    }
}