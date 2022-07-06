using Entities.Concretes;
using Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstracts
{
    public interface ICarService
    {
        void Add(Car car);
        void Update(Car car);
        void Delete(Car car);
        Car GetById(int id);
        List<Car> GetAll();
        List<GetCarDto> GetAllDetails();
        List<Car> GetAllByBrandId(int id);
        List<Car> GetAllByColorId(int id);
    }
}
