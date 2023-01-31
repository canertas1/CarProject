using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concretes
{
    public class CarManager : ICarService
    {

        private ICarDal _carDal;

        public CarManager(ICarDal carDal) { 
            this._carDal = carDal;

        }

        public void Add(Car car)
        {
            if (car.Name.Length > 2 && car.DailyPrice > 0) { 
            
                this._carDal.Add(car);
            }
        }

        public List<Car> GetAll()
        {
            return this._carDal.GetAll();
        }

        public List<Car> GetCarsByBrandId(int brandId)
        {
            return this._carDal.GetAll(p=>p.BrandId==brandId);
        }

        public List<Car> GetCarsByColorId(int colorId)
        {
            return this._carDal.GetAll(p=>p.ColorId==colorId);
        }
    }
}
