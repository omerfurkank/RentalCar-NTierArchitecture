using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstracts
{
    public interface IColorService
    {
        void Add(Color color);
        void Update(Color color);
        void Delete(Color color);
    }
}
