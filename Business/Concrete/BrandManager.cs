using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class BrandManager : IBrandService
    {
        IBrandDal _brandDal;

        public BrandManager(IBrandDal brandDal)
        {
            _brandDal=brandDal;
        }
        public void Add(Brand brand)
        {
            _brandDal.Add(brand);
        }

        public Brand GetBrandById(int id)
        {
            return _brandDal.GetById(b => b.Id == id);
        }

        public List<Brand> GetBrands()
        {
            return _brandDal.GetAll();
        }
    }
}
