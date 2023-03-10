using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICarService
    {
        List<Car> GetAll();
        void Add(Car car);
        List<Car> GetCarsByBrandId(int brandId);

        List<Car> GetCarsByColorId(int colorId);

    }
}
