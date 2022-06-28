using Core.Entities;
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
        public int Id { get; set; }
        public string CompanyName { get; set; }
        [JsonIgnore]
        public List<Rental>? Rentals { get; set; } = new();
    }
}
