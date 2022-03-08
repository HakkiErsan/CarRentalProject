using Core.DataAccess;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, CarRentalDbContext>, ICarDal
    {
        public List<CarDetailsDto> GetCarDetails()
        {
            using (var context = new CarRentalDbContext())
            {
                var result = from c in context.Cars
                             join b in context.Brands
                             on c.BrandId equals b.Id
                             join r in context.Colors on c.ColorId equals r.Id
                             select new CarDetailsDto
                             {
                                 CarId = c.Id,
                                 BrandName = b.BrandName,
                                 ColorName = r.ColorName,
                                 DailyPrice = c.DailyPrice,
                                 Description = c.Description
                             };
                return result.ToList();
            } 
        }
    }
}
