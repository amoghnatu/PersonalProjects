using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnowMyCar.Models
{
    public class SearchCriteria
    {
        public string searchTerm { get; set; }
        public bool IsWildCard { get; set; }
        public Car SearchedCar { get; set; }
    }
}
