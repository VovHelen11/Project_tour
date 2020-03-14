using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelAgency.BusinessLogic.Models
{
   public class DataCreatTourBL
    {
        public TourBL Tour { get; set; }

        public IEnumerable<HotelBL> Hotels { get; set; }

        public IEnumerable<string> TourTypes { get; set; }
    }
}
