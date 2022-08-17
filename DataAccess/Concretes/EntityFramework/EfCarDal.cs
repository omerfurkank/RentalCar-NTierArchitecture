using Core.DataAccess.EntityFramework;
using DataAccess.Abstracts;
using DataAccess.Concretes.EntityFramework.Contexts;
using Entities.Concretes;
using Entities.Dtos;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concretes.EntityFramework
{
    public class EfCarDal:EfEntityRepositoryBase<Car,RentalContext>,ICarDal
    {
        public List<GetCarDto> GetCarDetails()
        {
            using (RentalContext context = new RentalContext())
            {
                var list = context.Cars.Include(c => c.Brand).Include(c=>c.Color).ToList();
                List<GetCarDto> result = new List<GetCarDto>();
                foreach (var car in list)
                {
                    result.Add(new GetCarDto()
                    {
                        Brand = car.Brand.Name,
                        Color = car.Color.Name,
                        DailyPrice = car.DailyPrice,
                        Description = car.Description,
                        ModelYear = car.ModelYear
                    });
                }
                return result;
            }
        }
    }
}
