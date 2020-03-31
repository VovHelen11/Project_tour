using System;

namespace TravelAgency.BusinessLogic.Models
{
    public class CreateTourBL
    {
      
        public string Name { get; set; }

        public DateTime DepartureData { get; set; }

        public DateTime ArrivalDate { get; set; }

        public int PeopleCount { get; set; }

        public int TourTypeId { get; set; }

        public int HotelId { get; set; }

        public double Price { get; set; }
    }
}