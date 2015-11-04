using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KnowMyCar.Models;

namespace KnowMyCar.DataAccessLayer
{
    public interface ICarRepository
    {
        List<Car> GetCarsList();
        List<Car> GetSpecificCarsList(SearchCriteria searchCriteria);
        Car GetACar(Car car);
    }
}
