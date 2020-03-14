using System.Collections.Generic;
using TravelAgency.BusinessLogic.Models;
using TravelAgency.DataAccess.Models;

namespace TravelAgency.BusinessLogic.Interfaces
{
    public interface ITourService
    {
        IEnumerable<TourBL> GetTours();

        TourBL GetTour(int id);

        IEnumerable<TourBL> GetHotTours();

        void AddTour(TourBL tourBL);

    }
}