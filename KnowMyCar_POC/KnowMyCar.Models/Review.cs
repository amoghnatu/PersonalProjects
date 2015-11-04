using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KnowMyCar.Entities;

namespace KnowMyCar.Models
{
    public class Review
    {
        public Int32 ReviewID { get; set; }
        public int CarID { get; set; }
        public StarRating StarRating { get; set; }
        public RatingLevel RatingLevel { get; set; }
        public string ReviewDescription { get; set; }
    }
}
