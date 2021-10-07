using System;

namespace PI_1.Data.Models
{
    public class OrderEntity
    {
        public Guid Id { get; set; }
        public string ClientName { get; set; }
        public string Address { get; set; }
        public Guid CarId { get; set; }
        public CarEntity Car { get; set; }
    }
}
