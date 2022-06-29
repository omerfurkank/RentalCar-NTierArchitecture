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
    public class RentalManager : IRentalService
    {
        IRentalDal _dal;

        public RentalManager(IRentalDal dal)
        {
            _dal = dal;
        }

        public void Add(Rental rental)
        {
            _dal.Add(rental);
        }

        public void Delete(Rental rental)
        {
            _dal.Delete(rental);
        }

        public void Update(Rental rental)
        {
            _dal.Update(rental);
        }
    }
}
