using PI_1.Data.Models;
using System;

namespace PI_1.Models
{
    public record OrderViewModel
    {
        public Guid Id { get; init; }
        public string ClientName { get; init; }
        public string Address { get; init; }
        public CarViewModel Car { get; init; }
    }

    public static class OrderViewModelMapping
    {
        public static OrderViewModel ToOrderView(this OrderEntity orderEntity)
        {
            return new()
            {
                Id = orderEntity.Id,
                ClientName = orderEntity.ClientName,
                Address = orderEntity.Address,
                Car = orderEntity.Car.ToViewModel()
            };
        }
    }
}
