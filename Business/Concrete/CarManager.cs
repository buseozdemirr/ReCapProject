using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;
        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public List<Car> GetCarsByBrandId(int id)
        {
            return _carDal.GetAll(x=>x.BrandId == id);
        }

        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }

        public List<Car> GetCarsByColorId(int id)
        {
            return _carDal.GetAll(x => x.ColorId == id);
        }

        public void Add(Car car)
        {
            if(car.Brand.Name.Length >= 2 && car.DailyPrice > 0)
                 _carDal.Add(car) ;

        }

        public void Update(Car car)
        {
            throw new NotImplementedException();
        }

        public void Delete(Car car)
        {
            throw new NotImplementedException();
        }
    }
}
