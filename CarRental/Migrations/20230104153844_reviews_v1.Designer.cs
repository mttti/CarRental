﻿// <auto-generated />
using CarRental.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CarRental.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20230104153844_reviews_v1")]
    partial class reviewsv1
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.1");

            modelBuilder.Entity("CarRental.Models.Car", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Brand")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Color")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("TEXT");

                    b.Property<string>("ImgSrc")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsBroken")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Mileage")
                        .HasColumnType("INTEGER");

                    b.Property<int>("PriceListId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("PriceListId");

                    b.ToTable("cars");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Brand = "BMW",
                            Color = "Czarny",
                            Description = "Czarne bmw. Szybsze niż wiatr.",
                            ImgSrc = "bmw.png",
                            IsBroken = false,
                            Mileage = 100,
                            PriceListId = 1
                        },
                        new
                        {
                            Id = 2,
                            Brand = "AUDI",
                            Color = "Czerwony",
                            Description = "Czerwone audi. Brak dachu zwiększa przyspieszenie.",
                            ImgSrc = "audi.png",
                            IsBroken = true,
                            Mileage = 40,
                            PriceListId = 2
                        },
                        new
                        {
                            Id = 3,
                            Brand = "CITROEN",
                            Color = "Biały",
                            Description = "Biały Citroen. Duże gabarty pozwolą na komfortowe podróże dla całej rodziny.",
                            ImgSrc = "citroen.png",
                            IsBroken = false,
                            Mileage = 200,
                            PriceListId = 3
                        });
                });

            modelBuilder.Entity("CarRental.Models.PriceList", b =>
                {
                    b.Property<int>("PriceListId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("BasePrice")
                        .HasColumnType("TEXT");

                    b.Property<string>("CarType")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Price")
                        .HasColumnType("TEXT");

                    b.HasKey("PriceListId");

                    b.ToTable("priceLists");

                    b.HasData(
                        new
                        {
                            PriceListId = 1,
                            BasePrice = 800m,
                            CarType = "Kabriolet",
                            Price = 400m
                        },
                        new
                        {
                            PriceListId = 2,
                            BasePrice = 200m,
                            CarType = "Kompakt",
                            Price = 100m
                        },
                        new
                        {
                            PriceListId = 3,
                            BasePrice = 500m,
                            CarType = "SUV",
                            Price = 250m
                        });
                });

            modelBuilder.Entity("CarRental.Models.Review", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CarId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Rating")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("CarId");

                    b.ToTable("Reviews");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CarId = 1,
                            Description = "Przyjemnyd samochód",
                            Rating = 4
                        },
                        new
                        {
                            Id = 2,
                            CarId = 2,
                            Description = "Słaby samochód",
                            Rating = 2
                        },
                        new
                        {
                            Id = 3,
                            CarId = 3,
                            Description = "Średni samochód",
                            Rating = 3
                        });
                });

            modelBuilder.Entity("CarRental.Models.Car", b =>
                {
                    b.HasOne("CarRental.Models.PriceList", "PriceList")
                        .WithMany("cars")
                        .HasForeignKey("PriceListId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("PriceList");
                });

            modelBuilder.Entity("CarRental.Models.Review", b =>
                {
                    b.HasOne("CarRental.Models.Car", "Car")
                        .WithMany("Reviews")
                        .HasForeignKey("CarId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Car");
                });

            modelBuilder.Entity("CarRental.Models.Car", b =>
                {
                    b.Navigation("Reviews");
                });

            modelBuilder.Entity("CarRental.Models.PriceList", b =>
                {
                    b.Navigation("cars");
                });
#pragma warning restore 612, 618
        }
    }
}
