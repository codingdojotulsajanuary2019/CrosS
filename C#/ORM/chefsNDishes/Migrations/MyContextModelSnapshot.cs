﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using chefsNDishes.Models;

namespace chefsNDishes.Migrations
{
    [DbContext(typeof(MyContext))]
    partial class MyContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("chefsNDishes.Models.Chef", b =>
                {
                    b.Property<int>("ChefId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatedAt");

                    b.Property<DateTime>("DOB");

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<DateTime>("UpdatedAt");

                    b.HasKey("ChefId");

                    b.ToTable("Chefs");
                });

            modelBuilder.Entity("chefsNDishes.Models.Dish", b =>
                {
                    b.Property<int>("DishId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Calories");

                    b.Property<int>("ChefId");

                    b.Property<DateTime>("CreatedAt");

                    b.Property<string>("Description");

                    b.Property<string>("DishName");

                    b.Property<int>("Tastiness");

                    b.Property<DateTime>("UpdatedAt");

                    b.HasKey("DishId");

                    b.HasIndex("ChefId");

                    b.ToTable("Dishes");
                });

            modelBuilder.Entity("chefsNDishes.Models.Dish", b =>
                {
                    b.HasOne("chefsNDishes.Models.Chef", "Creator")
                        .WithMany("CreatedDishes")
                        .HasForeignKey("ChefId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
