using System.Collections.Generic;
using System.Data.Entity;
using TravelAgency.DataAccess.Models;

namespace TravelAgency.DataAccess
{
    public class TravelAgencyContextInitializer : DropCreateDatabaseAlways<TravelAgencyContext>
    {
        protected override void Seed(TravelAgencyContext context)
        {

            var hotelTypes = new List<HotelType>
            {
                 new HotelType
                 {
                     Name = "njgjgjff"
                 },
                 new HotelType
                 {
                     Name = "jdjfj"
                 }
            };
            hotelTypes.ForEach(str=>context.HotelTypes.Add(str));
            context.SaveChanges();
        }
    }
}