using Core.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfColorDal :EfEntityRepositoryBase<Color, ReCapProjectDbContext>,IColorDal
    {
       
    }
}
