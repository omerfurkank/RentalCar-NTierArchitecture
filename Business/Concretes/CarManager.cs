using Business.Abstracts;
using DataAccess.Abstracts;
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
        ICarDal dal;

        public CarManager(ICarDal dal)
        {
            this.dal = dal;
        }

        public void Add(Car car)
        {
            dal.Add(car);
        }

        public void Delete(Car car)
        {
            dal.Delete(car);
        }

        public List<Car> GetAll()
        {
           return dal.GetList();
        }

        public List<Car> GetAllByBrandId(int id)
        {
            return dal.GetList(p=>p.BrandId == id);
        }

        public List<Car> GetAllByColorId(int id)
        {
            return dal.GetList(p => p.ColorId == id);
        }

        public Car GetById(int id)
        {
            return dal.Get(p=>p.Id == id);
        }

        public void Update(Car car)
        {
            dal.Update(car);
        }
    }
}
