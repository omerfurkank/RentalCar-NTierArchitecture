using Core.CrossCuttingConcerns.Security.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Entities.Concretes
{
    public class Customer:User
    {
        public string CompanyName { get; set; }
        public virtual List<Rental>? Rentals { get; set; } = new();
    }
}
