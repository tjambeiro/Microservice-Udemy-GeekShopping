﻿// <auto-generated />
using GeekShopping.Product.API.Model.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace GeekShopping.Product.API.Migrations
{
    [DbContext(typeof(MySqlContext))]
    [Migration("20230628023155_SeedProductDataTable")]
    partial class SeedProductDataTable
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("GeekShopping.Product.API.Model.Products", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("id");

                    b.Property<string>("CategoryName")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("category_name");

                    b.Property<string>("Description")
                        .HasMaxLength(1000)
                        .HasColumnType("varchar(1000)")
                        .HasColumnName("description");

                    b.Property<string>("ImageURL")
                        .HasMaxLength(300)
                        .HasColumnType("varchar(300)")
                        .HasColumnName("image_url");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("varchar(150)")
                        .HasColumnName("name");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(65,30)")
                        .HasColumnName("price");

                    b.HasKey("Id");

                    b.ToTable("product");

                    b.HasData(
                        new
                        {
                            Id = 2L,
                            CategoryName = "Category",
                            Description = "Description",
                            Name = "Name2",
                            Price = 59.90m
                        },
                        new
                        {
                            Id = 3L,
                            CategoryName = "Category",
                            Description = "Description",
                            Name = "Name3",
                            Price = 59.90m
                        },
                        new
                        {
                            Id = 4L,
                            CategoryName = "Category",
                            Description = "Description",
                            Name = "Name4",
                            Price = 59.90m
                        },
                        new
                        {
                            Id = 5L,
                            CategoryName = "Category",
                            Description = "Description",
                            Name = "Name5",
                            Price = 59.90m
                        },
                        new
                        {
                            Id = 6L,
                            CategoryName = "Category",
                            Description = "Description",
                            Name = "Name6",
                            Price = 59.90m
                        },
                        new
                        {
                            Id = 7L,
                            CategoryName = "Category",
                            Description = "Description",
                            Name = "Name7",
                            Price = 59.90m
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
