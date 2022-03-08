using Business.Abstract;
using Business.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }
        public IResult AddCar(Car car)
        {
            _carDal.Add(car);
            return new SuccessResult("Eklendi");
        }

        public IDataResult<List<Car>> GetAllCar()
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(),"Eklendi");
        }

        public IDataResult<Car> GetCarById(int id)
        {
            return new SuccessDataResult<Car>(_carDal.GetById(c=>c.Id==id));
        }

        public IDataResult<List<Car>> GetCarsByBrandId(int id)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(c=>c.BrandId==id));
        }

        public IDataResult<List<Car>> GetCarsByColorId(int id)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(c => c.ColorId == id));
        }

        public IDataResult<List<CarDetailsDto>> GetirArabaDetay()
        {
            return new SuccessDataResult<List<CarDetailsDto>>(_carDal.GetCarDetails());
        }
    }
}
