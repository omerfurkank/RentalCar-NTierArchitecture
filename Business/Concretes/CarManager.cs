using Business.Abstracts;
using Business.BusinessAspect.Autofac;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Validation;
using DataAccess.Abstracts;
using Entities.Concretes;
using Entities.Dtos;
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
            _dal = dal;
        }
        //[SecuredOperation("admin")]
        [ValidationAspect(typeof(CarValidator))]
        public void Add(Car car)
        {
            _dal.Add(car);
        }
        public void Update(Car car)
        {
            _dal.Update(car);
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

        public List<GetCarDto> GetAllDetails()
        {
            return _dal.GetCarDetails();
        }
    }
}
