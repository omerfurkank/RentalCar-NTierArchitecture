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
    public class CustomerManager : ICustomerService
    {
        ICustomerDal _dal;

        public CustomerManager(ICustomerDal dal)
        {
            _dal = dal;
        }

        public void Add(Customer customer)
        {
            _dal.Add(customer);
        }

        public void Delete(Customer customer)
        {
            _dal.Delete(customer);
        }

        public void Update(Customer customer)
        {
           _dal.Update(customer);
        }
        public List<Customer> GetAll()
        {
            return _dal.GetList();
        }
    }
}
