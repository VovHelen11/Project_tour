using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TravelAgency.Models.Model
{
    public class DataCreatTourVM
    {
        public TourVM Tour { get; set; }

        public IEnumerable<HotelVM> Hotels { get; set; }

        public IEnumerable<string> TourTypes { get; set; }
    }
}