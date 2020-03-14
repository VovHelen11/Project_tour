﻿using System.Collections.Generic;

namespace TravelAgency.DataAccess.Models
{
    public class User:BaseEntity
    {

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string MobilePhone { get; set; }

        public virtual ICollection<Tour> Tours { get; set; }

    }
}
