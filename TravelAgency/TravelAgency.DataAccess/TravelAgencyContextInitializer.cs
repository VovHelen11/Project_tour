using System;
using System.Collections.Generic;
using System.Data.Entity;
using TravelAgency.DataAccess.Models;

namespace TravelAgency.DataAccess
{
    public class TravelAgencyContextInitializer : DropCreateDatabaseAlways<TravelAgencyContext>
    {
        protected override void Seed(TravelAgencyContext context)
        {
            var user = new User()
            {
                FirstName = "lena",
                LastName = "kha",
                Login = "lenakha",
                Password = "123",
                MobilePhone = "+3805050505",
                UserType = UserType.Admin
            };

            context.Users.Add(user);

            var hotelAddress = new HotelAddress
            {
                City = "London",
                Country = "GB",
                Street = "Lenina 6b"
            };

            hotelAddress = context.HotelAddresses.Add(hotelAddress);

            var hotelType = new HotelType
            {
                Name = "Hostel"
            }; 
            var hotelType2 = new HotelType
            {
                Name = "Hostel2"
            };

            hotelType = context.HotelTypes.Add(hotelType);
            hotelType2 = context.HotelTypes.Add(hotelType2);


            var hotel = new Hotel
            {
                Name = "Hotel 1",
                HotelAddress = hotelAddress,
                HotelType = hotelType
            };

            var hotel2 = new Hotel
            {
                Name = "Hotel 2",
                HotelAddress = hotelAddress,
                HotelType = hotelType2
            };

            hotel = context.Hotels.Add(hotel);
            hotel2 = context.Hotels.Add(hotel2);

            var tourType = new TourType
            {
                Name = "Shoping"
            };

            var tourType2 = new TourType
            {
                Name = "resort"
            };

            tourType = context.TourTypes.Add(tourType);
            tourType2 = context.TourTypes.Add(tourType2);


            var tour = new Tour
            {
                Name = "1",
                ArrivalDate = new DateTime(2020, 7, 11),
                DepartureData = new DateTime(2020, 7, 2),
                PeopleCount = 2,
                Price = 1000,
                TourType = tourType,
                Hotel = hotel2
            };
            var tour2 = new Tour
            {
                Name = "1",
                ArrivalDate = new DateTime(2020, 7, 11),
                DepartureData = new DateTime(2020, 7, 2),
                PeopleCount = 2,
                Price = 5000,
                TourType = tourType,
                Hotel = hotel,
                Hot = true

            }; var tour3 = new Tour
            {
                Name = "1",
                ArrivalDate = new DateTime(2020, 7, 11),
                DepartureData = new DateTime(2020, 7, 2),
                PeopleCount = 2,
                Price = 5000,
                TourType = tourType2,
                Hotel = hotel
            };
            var tour4 = new Tour
            {
                Name = "1",
                ArrivalDate = new DateTime(2020, 7, 11),
                DepartureData = new DateTime(2020, 7, 2),
                PeopleCount = 2,
                Price = 2000,
                TourType = tourType2,
                Hotel = hotel2,
                Hot = true

            };
            context.Tours.Add(tour);
            context.Tours.Add(tour2);
            context.Tours.Add(tour3);
            context.Tours.Add(tour4);

            context.SaveChanges();



           
        }
    }
}