using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KnowMyCar.Entities;
using KnowMyCar.Models;

namespace KnowMyCar.DataAccessLayer
{
    public class CarRepository : ICarRepository
    {
        private static List<Car> carsList;
        public CarRepository()
        {
        }
        public Car GetACar(Car car)
        {
            if (carsList == null)
            {
                this.LoadAllCars();
            }
            return carsList
                    .FirstOrDefault(c =>
                   c.CarName.ToLower().Contains(car.CarName.ToLower())
                && c.CarType == car.CarType
                && c.CarClass == car.CarClass
                && c.CarFuelVariant == car.CarFuelVariant
                );
        }

        public List<Car> GetCarsList()
        {
            if (carsList == null)
            {
                this.LoadAllCars();
            }
            return carsList;
        }

        public List<Car> GetSpecificCarsList(SearchCriteria searchCriteria)
        {
            return this.GetSearchedCars(searchCriteria);
        }

        private void LoadAllCars()
        {
            carsList = new List<Car>();
            carsList.Add(
                new Car
                {
                    CarID = 1,
                    CarClass = CarClass.Economy,
                    CarName = "Alto Lxi",
                    CarFuelVariant = CarFuelVariant.Petrol,
                    CarReview = new Review { CarID = 1, RatingLevel = RatingLevel.Best, ReviewDescription = "Excellent Car", ReviewID = 1, StarRating = StarRating.FiveStars },
                    CarType = CarType.HatchBack,
                    Make = "Maruti Suzuki",
                    Model = "Alto Lxi",
                    MonthAndYearOfLaunch = "DEC, 2004",
                    GeneralNamesAndSearchTerms = "Maruti Alto, Alto, Alto Lxi, Maruti Suzuki Alto, Alto Maruti, suzuki Alto"
                });

            carsList.Add(
                new Car
                {
                    CarID = 2,
                    CarClass = CarClass.Sports,
                    CarName = "Swift Sport",
                    CarFuelVariant = CarFuelVariant.Diesel,
                    CarReview = new Review { CarID = 2, RatingLevel = RatingLevel.Good, ReviewDescription = "Good Car", ReviewID = 2, StarRating = StarRating.FourStars },
                    CarType = CarType.HatchBack,
                    Make = "Maruti Suzuki",
                    Model = "Swift Sport",
                    MonthAndYearOfLaunch = "Feb, 2015",
                    GeneralNamesAndSearchTerms = "Maruti Swift, swift, swift sport, Maruti Suzuki swift, swift Maruti, suzuki swift"
                });

            carsList.Add(
                new Car
                {
                    CarID = 2,
                    CarClass = CarClass.Luxury,
                    CarName = "Phantom",
                    CarFuelVariant = CarFuelVariant.Petrol,
                    CarReview = new Review { CarID = 3, RatingLevel = RatingLevel.Best, ReviewDescription = "Excellent Car. Pure Luxury", ReviewID = 3, StarRating = StarRating.FiveStars },
                    CarType = CarType.Sedan,
                    Make = "Rolls Royce",
                    Model = "Phantom Coupe",
                    MonthAndYearOfLaunch = "DEC, 2014",
                    GeneralNamesAndSearchTerms = "Rolls Royce Phantom, RR, Phantom, Phantom Coupe, rollsroyce, phantom rolls royce, Phantom Rolls, rolls"
                });

            carsList.Add(
                new Car
                {
                    CarID = 4,
                    CarClass = CarClass.MidRange,
                    CarName = "Ciaz ZDI SHVS",
                    CarFuelVariant = CarFuelVariant.Diesel,
                    CarReview = new Review { CarID = 4, RatingLevel = RatingLevel.Best, ReviewDescription = "Great Hybrid Car", ReviewID = 4, StarRating = StarRating.FiveStars },
                    CarType = CarType.Sedan,
                    Make = "Maruti Suzuki",
                    Model = "Ciaz ZDI SHVS",
                    MonthAndYearOfLaunch = "SEP, 2015",
                    GeneralNamesAndSearchTerms = "Maruti Ciaz, Ciaz, Ciaz Zdi, Maruti Suzuki Ciaz, Ciaz zdi, ciaz shvs, maruti shvs, shvs, shvs ciaz, zdi ciaz, ciaz zdi shvs"
                });

            carsList.Add(
                new Car
                {
                    CarID = 5,
                    CarClass = CarClass.OffRoader,
                    CarName = "Evoque",
                    CarFuelVariant = CarFuelVariant.Petrol,
                    CarReview = new Review { CarID = 5, RatingLevel = RatingLevel.Best, ReviewDescription = "Wonderful Offroader", ReviewID = 5, StarRating = StarRating.FiveStars },
                    CarType = CarType.SUV,
                    Make = "Range Rover",
                    Model = "Evoque",
                    MonthAndYearOfLaunch = "AUG, 2013",
                    GeneralNamesAndSearchTerms = "Range rover evoque, evoque, evoque range rover"
                });
        }

        private List<Car> GetSearchedCars(SearchCriteria searchCriteria)
        {
            if (searchCriteria != null && searchCriteria.IsWildCard)
            {
                return carsList.Where(c => c.GeneralNamesAndSearchTerms.ToLower().Contains(searchCriteria.searchTerm)).ToList();
            }
            else
            {
                return carsList
                    .Where(c => 
                   c.CarName.ToLower().Contains(searchCriteria.SearchedCar.CarName.ToLower())
                && c.CarType != null ? c.CarType == searchCriteria.SearchedCar.CarType : true
                && c.CarClass != null ? c.CarClass == searchCriteria.SearchedCar.CarClass : true
                && c.CarFuelVariant != null ? c.CarFuelVariant == searchCriteria.SearchedCar.CarFuelVariant : true
                ).ToList();
            }
        }
    }
}
