﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ifes.lib.data;

namespace ifes.lib.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20200827102130_remove_planeIdFromPassenger")]
    partial class remove_planeIdFromPassenger
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");

                    b.HasDiscriminator<string>("Discriminator").HasValue("IdentityUser");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("ifes.lib.domain.Catalogs.Catalog", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("Catalog");
                });

            modelBuilder.Entity("ifes.lib.domain.Catalogs.CatalogItem", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("CatalogId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Discount")
                        .HasColumnType("float");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PaymentOption")
                        .HasColumnType("int");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("CatalogId");

                    b.ToTable("CatalogItem");

                    b.HasDiscriminator<string>("Discriminator").HasValue("CatalogItem");
                });

            modelBuilder.Entity("ifes.lib.domain.Catalogs.Order", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<Guid>("CatalogItemId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("PassengerId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<Guid>("PlaneId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CatalogItemId");

                    b.HasIndex("PassengerId");

                    b.HasIndex("PlaneId");

                    b.ToTable("Order");
                });

            modelBuilder.Entity("ifes.lib.domain.Planes.Airport", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Code")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Airport");
                });

            modelBuilder.Entity("ifes.lib.domain.Planes.FlightInfo", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("ExpectedArrival")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ExpectedDeparture")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("FromId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("ToId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("FromId");

                    b.HasIndex("ToId");

                    b.ToTable("FlightInfo");
                });

            modelBuilder.Entity("ifes.lib.domain.Planes.Plane", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("CatalogId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("TailNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CatalogId");

                    b.ToTable("Plane");
                });

            modelBuilder.Entity("ifes.lib.domain.Planes.Seat", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Col")
                        .IsRequired()
                        .HasColumnType("nvarchar(1)");

                    b.Property<int>("FlightClass")
                        .HasColumnType("int");

                    b.Property<Guid>("PlaneId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Row")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PlaneId");

                    b.ToTable("Seat");
                });

            modelBuilder.Entity("ifes.lib.domain.Users.ApplicationUser", b =>
                {
                    b.HasBaseType("Microsoft.AspNetCore.Identity.IdentityUser");

                    b.HasDiscriminator().HasValue("ApplicationUser");
                });

            modelBuilder.Entity("ifes.lib.domain.Catalogs.Beverage", b =>
                {
                    b.HasBaseType("ifes.lib.domain.Catalogs.CatalogItem");

                    b.Property<int>("BeverageType")
                        .HasColumnType("int");

                    b.HasDiscriminator().HasValue("Beverage");
                });

            modelBuilder.Entity("ifes.lib.domain.Catalogs.Food", b =>
                {
                    b.HasBaseType("ifes.lib.domain.Catalogs.CatalogItem");

                    b.Property<int>("FoodType")
                        .HasColumnType("int");

                    b.Property<int>("PreparationTime")
                        .HasColumnType("int");

                    b.HasDiscriminator().HasValue("Food");
                });

            modelBuilder.Entity("ifes.lib.domain.Catalogs.MultiMedia", b =>
                {
                    b.HasBaseType("ifes.lib.domain.Catalogs.CatalogItem");

                    b.Property<int>("Duration")
                        .HasColumnType("int");

                    b.Property<string>("FileExtension")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("FileSize")
                        .HasColumnType("int");

                    b.Property<string>("ObjectStorageId")
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue("MultiMedia");
                });

            modelBuilder.Entity("ifes.lib.domain.Users.CabinCrew", b =>
                {
                    b.HasBaseType("ifes.lib.domain.Users.ApplicationUser");

                    b.Property<Guid?>("PlaneId")
                        .HasColumnType("uniqueidentifier");

                    b.HasIndex("PlaneId");

                    b.HasDiscriminator().HasValue("CabinCrew");
                });

            modelBuilder.Entity("ifes.lib.domain.Users.Passenger", b =>
                {
                    b.HasBaseType("ifes.lib.domain.Users.ApplicationUser");

                    b.Property<string>("ReservationCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("SeatId")
                        .HasColumnType("uniqueidentifier");

                    b.HasIndex("SeatId")
                        .IsUnique()
                        .HasFilter("[SeatId] IS NOT NULL");

                    b.HasDiscriminator().HasValue("Passenger");
                });

            modelBuilder.Entity("ifes.lib.domain.Catalogs.Audio", b =>
                {
                    b.HasBaseType("ifes.lib.domain.Catalogs.MultiMedia");

                    b.HasDiscriminator().HasValue("Audio");
                });

            modelBuilder.Entity("ifes.lib.domain.Catalogs.Video", b =>
                {
                    b.HasBaseType("ifes.lib.domain.Catalogs.MultiMedia");

                    b.Property<string>("Category")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Rating")
                        .HasColumnType("int");

                    b.HasDiscriminator().HasValue("Video");
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
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
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

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ifes.lib.domain.Catalogs.CatalogItem", b =>
                {
                    b.HasOne("ifes.lib.domain.Catalogs.Catalog", null)
                        .WithMany("Items")
                        .HasForeignKey("CatalogId");
                });

            modelBuilder.Entity("ifes.lib.domain.Catalogs.Order", b =>
                {
                    b.HasOne("ifes.lib.domain.Catalogs.CatalogItem", "Item")
                        .WithMany()
                        .HasForeignKey("CatalogItemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ifes.lib.domain.Users.Passenger", "Passenger")
                        .WithMany("Orders")
                        .HasForeignKey("PassengerId");

                    b.HasOne("ifes.lib.domain.Planes.Plane", null)
                        .WithMany("Orders")
                        .HasForeignKey("PlaneId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ifes.lib.domain.Planes.FlightInfo", b =>
                {
                    b.HasOne("ifes.lib.domain.Planes.Airport", "From")
                        .WithMany()
                        .HasForeignKey("FromId");

                    b.HasOne("ifes.lib.domain.Planes.Airport", "To")
                        .WithMany()
                        .HasForeignKey("ToId");
                });

            modelBuilder.Entity("ifes.lib.domain.Planes.Plane", b =>
                {
                    b.HasOne("ifes.lib.domain.Catalogs.Catalog", "Catalog")
                        .WithMany()
                        .HasForeignKey("CatalogId");
                });

            modelBuilder.Entity("ifes.lib.domain.Planes.Seat", b =>
                {
                    b.HasOne("ifes.lib.domain.Planes.Plane", null)
                        .WithMany("Seats")
                        .HasForeignKey("PlaneId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ifes.lib.domain.Users.CabinCrew", b =>
                {
                    b.HasOne("ifes.lib.domain.Planes.Plane", null)
                        .WithMany("CabinCrew")
                        .HasForeignKey("PlaneId");
                });

            modelBuilder.Entity("ifes.lib.domain.Users.Passenger", b =>
                {
                    b.HasOne("ifes.lib.domain.Planes.Seat", "Seat")
                        .WithOne("Passenger")
                        .HasForeignKey("ifes.lib.domain.Users.Passenger", "SeatId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
