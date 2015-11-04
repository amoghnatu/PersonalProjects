using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KnowMyCar.DataAccessLayer;
using KnowMyCar.Models;

namespace KnowMyCar_POC.Business_Services
{
    public class CarBusinessServices : ICarBusinessServices
    {
        ICarRepository carRepository = null;

        public CarBusinessServices()
        {
            carRepository = new CarRepository();
        }

        public Car GetACar(Car car)
        {
            return carRepository.GetACar(car);
        }

        public List<Car> GetCarsList()
        {
            return carRepository.GetCarsList();
        }

        public List<Car> GetSpecificCarsList(SearchCriteria searchCriteria)
        {
            return carRepository.GetSpecificCarsList(searchCriteria);
        }
    }
}
