using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Entities.Concretes
{
    public class Color:IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [JsonIgnore]
        public List<Car>? Cars { get; set; } = new();
    }
}
