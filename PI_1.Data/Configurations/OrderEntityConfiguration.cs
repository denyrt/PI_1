using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PI_1.Data.Models;

namespace PI_1.Data.Configurations
{
    public class OrderEntityConfiguration : IEntityTypeConfiguration<OrderEntity>
    {
        public void Configure(EntityTypeBuilder<OrderEntity> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.ClientName).HasMaxLength(100).IsRequired();
            builder.Property(x => x.Address).HasMaxLength(500).IsRequired();
            builder
                .HasOne(x => x.Car)
                .WithMany(x => x.Orders)
                .HasForeignKey(x => x.CarId)
                .IsRequired();
        }
    }
}
