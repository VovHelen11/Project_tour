using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelAgency.BusinessLogic.Models;

namespace TravelAgency.DataAccess.Models
{
    public class User:BaseEntity
    {

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string MobilePhone { get; set; }

        public ICollection<Tour> Tours { get; set; }

    }
}
