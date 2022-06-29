using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstracts
{
    public interface IRentalService
    {
        void Add(Rental rental);
        void Update(Rental rental);
        void Delete(Rental rental);
    }
}
