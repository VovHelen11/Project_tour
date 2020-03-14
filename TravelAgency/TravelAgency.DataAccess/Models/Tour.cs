using System;

namespace TravelAgency.DataAccess.Models
{
    public class Tour : BaseEntity
    {
        public string Name { get; set; }

        public DateTime DepartureData { get; set; }

        public DateTime ArrivalDate { get; set; }

        public int PeopleCount { get; set; }

        public virtual TourType TourType { get; set; }

        public virtual Hotel Hotel { get; set; }

        public double Price { get; set; }

        public bool Hot { get; set; }
    }
}
