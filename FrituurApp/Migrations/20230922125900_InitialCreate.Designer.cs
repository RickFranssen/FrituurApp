﻿// <auto-generated />
using System;
using FrituurApp.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FrituurApp.Migrations
{
    [DbContext(typeof(AppDBContext))]
    [Migration("20230922125900_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("FrituurApp.Models.Administrator", b =>
                {
                    b.Property<int>("AdministratorID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AdministratorID"));

                    b.Property<string>("AdministratorName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AdministratorID");

                    b.ToTable("Administrator");
                });

            modelBuilder.Entity("FrituurApp.Models.Customer", b =>
                {
                    b.Property<int>("CustomerID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CustomerID"));

                    b.Property<string>("CustomerEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CustomerName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CustomerID");

                    b.ToTable("Customer");
                });

            modelBuilder.Entity("FrituurApp.Models.Order", b =>
                {
                    b.Property<int>("OrderID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OrderID"));

                    b.Property<int>("CustomerID")
                        .HasColumnType("int");

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("OrderTotal")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("OrderID");

                    b.HasIndex("CustomerID");

                    b.ToTable("Order");
                });

            modelBuilder.Entity("FrituurApp.Models.OrderLine", b =>
                {
                    b.Property<int>("OrderLineID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OrderLineID"));

                    b.Property<decimal>("Amount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int?>("OrderID")
                        .HasColumnType("int");

                    b.HasKey("OrderLineID");

                    b.HasIndex("OrderID");

                    b.ToTable("OrderLine");
                });

            modelBuilder.Entity("FrituurApp.Models.Product", b =>
                {
                    b.Property<int>("ProductID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProductID"));

                    b.Property<int?>("AdministratorID")
                        .HasColumnType("int");

                    b.Property<int?>("CustomerID")
                        .HasColumnType("int");

                    b.Property<int?>("OrderLineID")
                        .HasColumnType("int");

                    b.Property<string>("ProductCategory")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProductDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProductName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProductPhoto")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal?>("ProductPrice")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("ProductID");

                    b.HasIndex("AdministratorID");

                    b.HasIndex("CustomerID");

                    b.HasIndex("OrderLineID");

                    b.ToTable("Product");
                });

            modelBuilder.Entity("FrituurApp.Models.Order", b =>
                {
                    b.HasOne("FrituurApp.Models.Customer", "Customer")
                        .WithMany("Orders")
                        .HasForeignKey("CustomerID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("FrituurApp.Models.OrderLine", b =>
                {
                    b.HasOne("FrituurApp.Models.Order", "Order")
                        .WithMany("Orderlines")
                        .HasForeignKey("OrderID");

                    b.Navigation("Order");
                });

            modelBuilder.Entity("FrituurApp.Models.Product", b =>
                {
                    b.HasOne("FrituurApp.Models.Administrator", "Administrator")
                        .WithMany("Products")
                        .HasForeignKey("AdministratorID");

                    b.HasOne("FrituurApp.Models.Customer", "Customer")
                        .WithMany("Products")
                        .HasForeignKey("CustomerID");

                    b.HasOne("FrituurApp.Models.OrderLine", "OrderLine")
                        .WithMany("Products")
                        .HasForeignKey("OrderLineID");

                    b.Navigation("Administrator");

                    b.Navigation("Customer");

                    b.Navigation("OrderLine");
                });

            modelBuilder.Entity("FrituurApp.Models.Administrator", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("FrituurApp.Models.Customer", b =>
                {
                    b.Navigation("Orders");

                    b.Navigation("Products");
                });

            modelBuilder.Entity("FrituurApp.Models.Order", b =>
                {
                    b.Navigation("Orderlines");
                });

            modelBuilder.Entity("FrituurApp.Models.OrderLine", b =>
                {
                    b.Navigation("Products");
                });
#pragma warning restore 612, 618
        }
    }
}
