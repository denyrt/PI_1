﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PI_1.Data.Contexts;

namespace PI_1.Data.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.10")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("PI_1.Data.Models.CarEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("CarEntities");

                    b.HasData(
                        new
                        {
                            Id = new Guid("07c2b12a-44d5-4413-baf2-d379720bd96b"),
                            Name = "Tesla 1",
                            Price = 1000.0
                        },
                        new
                        {
                            Id = new Guid("611750aa-da8b-458f-bef5-69ec194cc167"),
                            Name = "Tesla 2",
                            Price = 2000.0
                        },
                        new
                        {
                            Id = new Guid("c5c1f5ea-e74a-41fc-96f3-040e58ab9a77"),
                            Name = "Tesla X",
                            Price = 5000.0
                        });
                });

            modelBuilder.Entity("PI_1.Data.Models.OrderEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<Guid>("CarId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ClientName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.HasIndex("CarId");

                    b.ToTable("OrderEntities");
                });

            modelBuilder.Entity("PI_1.Data.Models.OrderEntity", b =>
                {
                    b.HasOne("PI_1.Data.Models.CarEntity", "Car")
                        .WithMany("Orders")
                        .HasForeignKey("CarId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Car");
                });

            modelBuilder.Entity("PI_1.Data.Models.CarEntity", b =>
                {
                    b.Navigation("Orders");
                });
#pragma warning restore 612, 618
        }
    }
}
