using System.Collections.Generic;

namespace TravelAgency.Models
{
    public interface ITourTypeService
    {
        IEnumerable<TourTypeBL> GetTourTypes();

        
    }
}
