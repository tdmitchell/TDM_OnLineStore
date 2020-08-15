﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TDM_OnLineStore.Repository;

namespace TDM_OnLineStore.Repository.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20200812203828_ProductSeeddata")]
    partial class ProductSeeddata
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("TDM_OnLineStore.Dominium.Models.Entity.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<DateTime>("DeliveryDate");

                    b.Property<int>("Number");

                    b.Property<DateTime>("OrderDate");

                    b.Property<int>("PaymentId");

                    b.Property<string>("PostalCode")
                        .IsRequired()
                        .HasMaxLength(6);

                    b.Property<string>("Province")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<int>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("PaymentId");

                    b.HasIndex("UserId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("TDM_OnLineStore.Dominium.Models.Entity.OrderItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("OrderId");

                    b.Property<int>("ProductId");

                    b.Property<int>("Quantity");

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.ToTable("OrderItems");
                });

            modelBuilder.Entity("TDM_OnLineStore.Dominium.Models.Entity.Payment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("Payments");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Payment by Boleto",
                            Name = "Boleto"
                        },
                        new
                        {
                            Id = 2,
                            Description = "Payment by Credict Card",
                            Name = "Credict Card"
                        },
                        new
                        {
                            Id = 3,
                            Description = "Payment by Deposit",
                            Name = "Deposit"
                        });
                });

            modelBuilder.Entity("TDM_OnLineStore.Dominium.Models.Entity.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(400);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<decimal>("Price");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Description for Product 1",
                            Name = "Product Test 1",
                            Price = 10m
                        },
                        new
                        {
                            Id = 2,
                            Description = "Description for Product 2",
                            Name = "Credict Card",
                            Price = 20.2m
                        },
                        new
                        {
                            Id = 3,
                            Description = "Description for Product 3",
                            Name = "Deposit",
                            Price = 30.3m
                        });
                });

            modelBuilder.Entity("TDM_OnLineStore.Dominium.Models.Entity.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<bool>("IsAdmin");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(400);

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("TDM_OnLineStore.Dominium.Models.Entity.Order", b =>
                {
                    b.HasOne("TDM_OnLineStore.Dominium.Models.Entity.Payment", "Payment")
                        .WithMany()
                        .HasForeignKey("PaymentId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("TDM_OnLineStore.Dominium.Models.Entity.User", "User")
                        .WithMany("Orders")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("TDM_OnLineStore.Dominium.Models.Entity.OrderItem", b =>
                {
                    b.HasOne("TDM_OnLineStore.Dominium.Models.Entity.Order")
                        .WithMany("OrderItens")
                        .HasForeignKey("OrderId");
                });
#pragma warning restore 612, 618
        }
    }
}
