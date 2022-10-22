using Entities.Concrete;


namespace Business.Abstract
{
    public interface ICarService
    {
        List<Car> GetAll();
        List<Car> GetCarsByBrandId(int id);
        List<Car> GetCarsByColorId(int id);
        public void Add(Car car);
        public void Update(Car car);
        public void Delete(Car car);
    }
}
