using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KnowMyCar.Models;

namespace KnowMyCar_POC.Business_Services
{
    public interface ICarBusinessServices
    {
        List<Car> GetCarsList();
        List<Car> GetSpecificCarsList(SearchCriteria searchCriteria);
        Car GetACar(Car car);
    }
}
