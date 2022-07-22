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
    public class ColorManager:IColorService
    {
        IColorDal _dal;

        public ColorManager(IColorDal dal)
        {
            _dal = dal;
        }

        public void Add(Color color)
        {
            _dal.Add(color);
        }

        public void Delete(Color color)
        {
            _dal.Delete(color);
        }

        public void Update(Color color)
        {
            _dal.Update(color);
        }
    }
}
