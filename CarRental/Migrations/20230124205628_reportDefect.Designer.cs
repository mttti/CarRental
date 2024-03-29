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
    [Migration("20230124205628_reportDefect")]
    partial class reportDefect
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
                            ConcurrencyStamp = "de3999ea-0fd1-4f52-b0fd-64f25ea6e5d0",
                            Email = "admin@admin.pl",
                            EmailConfirmed = false,
                            LastName = "Magiera",
                            LockoutEnabled = false,
                            Name = "Mateusz",
                            NormalizedEmail = "ADMIN@ADMIN.PL",
                            NormalizedUserName = "ADMIN",
                            PasswordHash = "AQAAAAEAACcQAAAAEF2Q8w0vvgx+Pg3C09ypa0xZoZ3HkYRPfOpF0MzrS9pQyc+PafZrv4yl/XiFHWZRvQ==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "dc21864f-f4a6-42fd-bc41-7c06bd3a7fdf",
                            TwoFactorEnabled = false,
                            UserName = "Admin"
                        },
                        new
                        {
                            Id = "ff023250-c33f-48c2-80b8-703f5ab34531",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "884d0165-75b6-46f0-af3b-8d15c74559ed",
                            Email = "Mietekmechanik@onet.pl",
                            EmailConfirmed = false,
                            LastName = "Kowalski",
                            LockoutEnabled = false,
                            Name = "Mieczyslaw",
                            NormalizedEmail = "MIETEKMECHANIK@ONET.PL",
                            NormalizedUserName = "MIETEKMECHANIK",
                            PasswordHash = "AQAAAAEAACcQAAAAELUFwWw0eBqlrh7K7bXrnT/EQY7OiVPX8U4bxx8fI0wmfSa3p6GUarJSV9LTh6qv5Q==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "d865a84e-8ef0-4d1a-90d5-315ded0e14de",
                            TwoFactorEnabled = false,
                            UserName = "MietekMechanik"
                        },
                        new
                        {
                            Id = "a4d55acc-2778-48ed-bd6e-7d454db01b09",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "d1602460-de2a-4cbd-bbd1-91e0e6895073",
                            Email = "jnowak@interia.pl",
                            EmailConfirmed = false,
                            LastName = "Kowalski",
                            LockoutEnabled = false,
                            Name = "Jan",
                            NormalizedEmail = "JNOWAK@INTERIA.PL",
                            NormalizedUserName = "NOWAK_JAN",
                            PasswordHash = "AQAAAAEAACcQAAAAEAvJjS1Mgc1+JIfHcdra2VovsKk3D54O/u94FOjEoxd5pz15p7Bqag0Y8HVZem/Kbw==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "a101897b-f90e-4a8e-aa2d-370dda9d8693",
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
                            IsBroken = true,
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

                    b.Property<string>("DamageDescription")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("TEXT");

                    b.Property<bool?>("IsReviewed")
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("Price")
                        .HasColumnType("TEXT");

                    b.Property<int?>("Rating")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("orders");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CarId = 1,
                            EndDate = new DateTime(2023, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified),
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
                            ConcurrencyStamp = "3e36419a-89d0-4c31-bc88-9418b9d593d7",
                            Name = "admin",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
                            Id = "5d1880d4-bc4a-4873-9043-5320c72b35c0",
                            ConcurrencyStamp = "4c44a13c-83fe-4c7b-97cd-789a197b172a",
                            Name = "mechanik",
                            NormalizedName = "MECHANIK"
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
