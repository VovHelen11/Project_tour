﻿using System;

namespace TravelAgency.DataAccess.Models
{
    public class Tour:BaseEntity
    {
        public string Name { get; set; }

       public DateTime DepartureData { get; set; }

        public DateTime ArrivalDate { get; set; }

        public int PeopleCount { get; set; }

        public TourType TourType { get; set; }

        public Hotel Hotel { get; set; }

        public double Price { get; set; }

    }
}
