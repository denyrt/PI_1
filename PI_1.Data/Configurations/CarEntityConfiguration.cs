using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PI_1.Data.Models;
using System;

namespace PI_1.Data.Configurations
{
    public class CarEntityConfiguration : IEntityTypeConfiguration<CarEntity>
    {
        public void Configure(EntityTypeBuilder<CarEntity> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name).HasMaxLength(100).IsRequired();
            builder.Property(x => x.Price).IsRequired();

            builder.HasData(new CarEntity[] {
                new()
                {
                    Id = Guid.NewGuid(),
                    Name = "Tesla 1",
                    Price = 1000
                },
                new()
                {
                    Id = Guid.NewGuid(),
                    Name = "Tesla 2",
                    Price = 2000
                },
                new()
                {
                    Id = Guid.NewGuid(),
                    Name = "Tesla X",
                    Price = 5000
                },
            });
        }
    }
}
