using PI_1.Data.Models;
using System;

namespace PI_1.Models
{
    public record CarViewModel
    {
        public Guid Id { get; init; }
        public string Name { get; init; }
        public double Price { get; init; }
    }

    public static class CarViewModelMapping
    {
        public static CarViewModel ToViewModel(this CarEntity carEntity)
        {
            return new()
            {
                Id = carEntity.Id,
                Name = carEntity.Name,
                Price = carEntity.Price
            };
        }
    }
}
