using Business.Concrete;
using DataAccess.Concrete.EntityFramework;

public class Program
{
    public static void Main(string[] args)
    {
        CarManager carManager = new CarManager(new EfCarDal());
        foreach (var car in carManager.GetAll())
        {
            Console.WriteLine(car.CarId);
        }
    }
}