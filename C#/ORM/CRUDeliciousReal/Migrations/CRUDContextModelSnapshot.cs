﻿// <auto-generated />
using System;
using CRUDeliciousReal.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CRUDeliciousReal.Migrations
{
    [DbContext(typeof(CRUDContext))]
    partial class CRUDContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("CRUDeliciousReal.Models.User", b =>
                {
                    b.Property<int>("user_id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Email");

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<string>("Password");

                    b.Property<DateTime>("created_at");

                    b.Property<DateTime>("updated_at");

                    b.HasKey("user_id");

                    b.ToTable("users");
                });
#pragma warning restore 612, 618
        }
    }
}
