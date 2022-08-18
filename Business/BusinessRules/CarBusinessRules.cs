using DataAccess.Abstracts;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.BusinessRules
{
    public class CarBusinessRules
    {
        ICarDal _dal;

        public CarBusinessRules(ICarDal dal)
        {
            _dal = dal;
        }
        public void CheckIfCarNameExists(string carName)
        {
            var carToCheck = _dal.Get(c => c.Description == carName);

            if (carToCheck != null)
            {
                throw new Exception("This car name already exists");
            }
        }
    }
}
