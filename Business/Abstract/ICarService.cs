using Business.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICarService
    {
        IDataResult<List<Car>> GetAllCar();
        IDataResult<Car> GetCarById(int id);
        IResult AddCar(Car car);
        IDataResult<List<CarDetailsDto>> GetirArabaDetay();
        IDataResult<List<Car>> GetCarsByBrandId(int id);
        IDataResult<List<Car>> GetCarsByColorId(int id);
    }
}
