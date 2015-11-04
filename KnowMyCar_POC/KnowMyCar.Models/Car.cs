using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KnowMyCar.Entities;

namespace KnowMyCar.Models
{
    public class Car
    {
        public Int32 CarID { get; set; }
        public string CarName { get; set; }
        public CarType? CarType { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string MonthAndYearOfLaunch { get; set; }
        public CarFuelVariant? CarFuelVariant { get; set; }
        public string GeneralNamesAndSearchTerms { get; set; }
        public CarClass? CarClass { get; set; }
        public Review CarReview { get; set; }
    }
}
