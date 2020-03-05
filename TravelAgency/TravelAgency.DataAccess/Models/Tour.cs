using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelAgency.BusinessLogic.Models;

namespace TravelAgency.DataAccess.Models
{
    public class Tour:BaseEntity
    {
        public string Name { get; set; }

       public DateTime DepartureData { get; set; }

        public DateTime ArrivalDate { get; set; }

        public int PeopleCount { get; set; }

        public TourType TourType { get; set; }

        public HotelType HotelType { get; set; }

        public double Price { get; set; }

    }
}
