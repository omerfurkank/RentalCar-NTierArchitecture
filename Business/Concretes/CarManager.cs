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
        ICarDal _dal;

        public CarManager(ICarDal dal)
        {
            this._dal = dal;
        }

        public void Add(Car car)
        {
            _dal.Add(car);
        }

        public void Delete(Car car)
        {
            _dal.Delete(car);
        }

        public List<Car> GetAll()
        {
           return _dal.GetList();
        }

        public List<Car> GetAllByBrandId(int id)
        {
            return _dal.GetList(p=>p.BrandId == id);
        }

        public List<Car> GetAllByColorId(int id)
        {
            return _dal.GetList(p => p.ColorId == id);
        }

        public Car GetById(int id)
        {
            return _dal.Get(p=>p.Id == id);
        }

        public void Update(Car car)
        {
            _dal.Update(car);
        }
    }
}
