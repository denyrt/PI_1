using System;
using System.Collections.Generic;

namespace PI_1.Data.Models
{
    public class CarEntity
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public List<OrderEntity> Orders { get; set; }
    }
}