using Domain.SeedWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.AggregateModels.OrderModels
{
    public class Address:ValueObject
    {
        public string City { get; set; }
        public string District { get; set; }
    }
}
