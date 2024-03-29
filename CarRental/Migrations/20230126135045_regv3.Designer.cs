﻿// <auto-generated />
using System;
using CarRental.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CarRental.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20230126135045_regv3")]
    partial class regv3
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.1");

            modelBuilder.Entity("CarRental.Models.AppUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("INTEGER");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("INTEGER");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("TEXT");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("TEXT");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("INTEGER");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("TEXT");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("INTEGER");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "26481377-54b6-4866-9552-673295ea5e98",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "7eba0fc6-e8a5-4187-b15b-dc6dbe27388d",
                            Email = "admin@admin.pl",
                            EmailConfirmed = false,
                            LastName = "Magiera",
                            LockoutEnabled = false,
                            Name = "Mateusz",
                            NormalizedEmail = "ADMIN@ADMIN.PL",
                            NormalizedUserName = "ADMIN",
                            PasswordHash = "AQAAAAEAACcQAAAAEPU/gnnZJ1lzhJUQQG1di8y/XD11hDWv3+IV/TNubMfiwu7skU1rY+WlbKVz5v32OA==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "5aa45411-dc5b-4402-a7c2-ee0e1e87f9b8",
                            TwoFactorEnabled = false,
                            UserName = "Admin"
                        },
                        new
                        {
                            Id = "ff023250-c33f-48c2-80b8-703f5ab34531",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "871d3f77-d87a-4588-ad63-96dd1aa880ef",
                            Email = "Mietekmechanik@onet.pl",
                            EmailConfirmed = false,
                            LastName = "Kowalski",
                            LockoutEnabled = false,
                            Name = "Mieczyslaw",
                            NormalizedEmail = "MIETEKMECHANIK@ONET.PL",
                            NormalizedUserName = "MIETEKMECHANIK",
                            PasswordHash = "AQAAAAEAACcQAAAAEFTbp/nvfxuoEh4PyAv0rdKLNQwLV6zpooms6UZtJVXDDj9Ll9dTMqSXlSYKnUzlsg==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "5d373001-34c4-4422-bf82-ed69abfdeeb5",
                            TwoFactorEnabled = false,
                            UserName = "MietekMechanik"
                        },
                        new
                        {
                            Id = "a4d55acc-2778-48ed-bd6e-7d454db01b09",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "a6cf5e67-2865-4ee2-852e-4c20898d22e2",
                            Email = "jnowak@interia.pl",
                            EmailConfirmed = false,
                            LastName = "Kowalski",
                            LockoutEnabled = false,
                            Name = "Jan",
                            NormalizedEmail = "JNOWAK@INTERIA.PL",
                            NormalizedUserName = "NOWAK_JAN",
                            PasswordHash = "AQAAAAEAACcQAAAAEGZfkBVyaUwcc6h1zIKWgwkI7H+iW5YAYue0HkP/xFOmo6pGcj66ElkMZugAarSjlQ==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "29532793-68e6-4397-a95d-044d70e4a75a",
                            TwoFactorEnabled = false,
                            UserName = "Nowak_Jan"
                        });
                });

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

                    b.Property<string>("Model")
                        .IsRequired()
                        .HasColumnType("TEXT");

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
                            Model = "M850i",
                            PriceListId = 1
                        },
                        new
                        {
                            Id = 2,
                            Brand = "AUDI",
                            Color = "Czerwony",
                            Description = "Czerwone audi. Brak dachu zwiększa przyspieszenie.",
                            ImgSrc = "audi.png",
                            IsBroken = false,
                            Mileage = 40,
                            Model = "A3",
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
                            Model = "C5",
                            PriceListId = 3
                        });
                });

            modelBuilder.Entity("CarRental.Models.CarDefect", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CarId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("TEXT");

                    b.Property<bool?>("IsSolved")
                        .HasColumnType("INTEGER");

                    b.Property<int>("OrderId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("carDefects");
                });

            modelBuilder.Entity("CarRental.Models.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CarId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("TEXT");

                    b.Property<bool?>("IsReported")
                        .HasColumnType("INTEGER");

                    b.Property<bool?>("IsReviewed")
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("Price")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("CarId");

                    b.ToTable("orders");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CarId = 1,
                            EndDate = new DateTime(2023, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsReported = false,
                            IsReviewed = false,
                            Price = 1600m,
                            StartDate = new DateTime(2023, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UserId = "a4d55acc-2778-48ed-bd6e-7d454db01b09"
                        },
                        new
                        {
                            Id = 2,
                            CarId = 3,
                            EndDate = new DateTime(2023, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsReported = false,
                            IsReviewed = false,
                            Price = 1600m,
                            StartDate = new DateTime(2023, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UserId = "a4d55acc-2778-48ed-bd6e-7d454db01b09"
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
                        .HasMaxLength(200)
                        .HasColumnType("TEXT");

                    b.Property<int>("OrderId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Rating")
                        .HasColumnType("INTEGER");

                    b.Property<string>("userName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("CarId");

                    b.ToTable("reviews");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CarId = 1,
                            Description = "Przyjemny samochód",
                            OrderId = 0,
                            Rating = 4,
                            userName = "Joanna"
                        },
                        new
                        {
                            Id = 2,
                            CarId = 2,
                            Description = "Słaby samochód",
                            OrderId = 0,
                            Rating = 2,
                            userName = "Jakub"
                        },
                        new
                        {
                            Id = 3,
                            CarId = 3,
                            Description = "Średni samochód",
                            OrderId = 0,
                            Rating = 3,
                            userName = "Michał"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "0773fad5-d7e7-47e1-9ef8-6fad8120694f",
                            ConcurrencyStamp = "b576b8f8-0954-4a9a-a792-12e30a972d4b",
                            Name = "admin",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
                            Id = "5d1880d4-bc4a-4873-9043-5320c72b35c0",
                            ConcurrencyStamp = "d25fff5f-5d37-48d3-9e1f-26c05cfc9191",
                            Name = "mechanik",
                            NormalizedName = "MECHANIK"
                        },
                        new
                        {
                            Id = "e2293ff5-14f7-4a5d-8e36-6ec3107d0f99",
                            ConcurrencyStamp = "1c395c91-8cd0-42f9-8f4a-cec42ad41657",
                            Name = "uzytkownik",
                            NormalizedName = "UZYTKOWNIK"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ClaimType")
                        .HasColumnType("TEXT");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("TEXT");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ClaimType")
                        .HasColumnType("TEXT");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("TEXT");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("TEXT");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("TEXT");

                    b.Property<string>("RoleId")
                        .HasColumnType("TEXT");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);

                    b.HasData(
                        new
                        {
                            UserId = "26481377-54b6-4866-9552-673295ea5e98",
                            RoleId = "0773fad5-d7e7-47e1-9ef8-6fad8120694f"
                        },
                        new
                        {
                            UserId = "ff023250-c33f-48c2-80b8-703f5ab34531",
                            RoleId = "5d1880d4-bc4a-4873-9043-5320c72b35c0"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("TEXT");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("Value")
                        .HasColumnType("TEXT");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
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

            modelBuilder.Entity("CarRental.Models.Order", b =>
                {
                    b.HasOne("CarRental.Models.Car", "Car")
                        .WithMany("Orders")
                        .HasForeignKey("CarId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Car");
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

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("CarRental.Models.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("CarRental.Models.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CarRental.Models.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("CarRental.Models.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CarRental.Models.Car", b =>
                {
                    b.Navigation("Orders");

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
