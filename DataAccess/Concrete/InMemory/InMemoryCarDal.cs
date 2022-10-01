using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car>
             {
                 new Car {CarId = 1, BrandId = 1, ColorId = 3, DailyPrice = 254005, ModelYear = "2022", Description = "aa"},
                 new Car{CarId = 2,BrandId = 2,ColorId = 3,DailyPrice = 254005, ModelYear = "2022",Description = "assa"},
                 new Car{CarId = 3,BrandId = 3,ColorId = 32,DailyPrice = 5411, ModelYear = "2022",Description = "aass"},
                 new Car{CarId = 4,BrandId = 4,ColorId = 3,DailyPrice = 8520, ModelYear = "2022",Description = "aasss"},
                 new Car{CarId = 5,BrandId = 5,ColorId = 3,DailyPrice = 98742, ModelYear = "2023",Description = "aad"},

             };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(x => x.CarId == car.CarId);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars.ToList();
        }

        public Car GetById(int carId)
        {
            return _cars.SingleOrDefault(x => x.CarId == carId);
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(x => x.CarId == car.CarId);
            carToUpdate.CarId = car.CarId;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.Description = car.Description;

           
        }
    }
}
