using Core.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;


namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal:EfEntityRepositoryBase<Car,ReCapProjectDbContext>,ICarDal
    {
       
    }
}
