using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using System;

namespace ConsoleG
{
    class Program
    {
        static void Main(string[] args)
        {
            //CarTest();
            BrandManager brandManager = new BrandManager(new EfBrandDal());

            foreach (var brand in brandManager.GetBrands())
            {
                Console.WriteLine(brand.BrandName);
            }

        }

        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());


            foreach (var car in carManager.GetirArabaDetay())
            {
                Console.WriteLine(car.BrandName + "/" + car.ColorName + "/" + car.DailyPrice);
            }

            Console.WriteLine("---------------------");

            foreach (var car in carManager.GetCarsByBrandId(2))
            {
                Console.WriteLine(car.ModelYear);
            }


            Console.WriteLine("-------------------");

            foreach (var car in carManager.GetCarsByColorId(2))
            {
                Console.WriteLine(car.Description);
            }
        }
    }
}
