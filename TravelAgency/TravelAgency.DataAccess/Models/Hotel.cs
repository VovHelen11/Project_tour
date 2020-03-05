using TravelAgency.BusinessLogic.Models;

namespace TravelAgency.DataAccess.Models
{
    public class Hotel:BaseEntity
    {
        public string Name { get; set; }

        public HotelType HotelType { get; set; }

        public HotelAddress HotelAddress { get; set; }
    }
}