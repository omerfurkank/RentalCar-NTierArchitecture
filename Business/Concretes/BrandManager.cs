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
    public class BrandManager:IBrandService
    {
        IBrandDal _dal;

        public BrandManager(IBrandDal dal)
        {
            _dal = dal;
        }

        public void Add(Brand brand)
        {
            _dal.Add(brand);
        }

        public void Delete(Brand brand)
        {
            _dal.Delete(brand);
        }

        public void Update(Brand brand)
        {
            _dal.Update(brand);
        }
    }
}
