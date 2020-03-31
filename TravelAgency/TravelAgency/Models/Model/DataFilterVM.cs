using System.Collections.Generic;

namespace TravelAgency.Models.Model
{
    public class DataFilterVM
    {
        public int HotelTypeId { get; set; }

        public int TourTypeId { get; set; }

        public double Price { get; set; }

        public int PeopleCount { get; set; }
    }
}