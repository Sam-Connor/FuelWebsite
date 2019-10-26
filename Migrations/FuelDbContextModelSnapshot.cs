﻿// <auto-generated />
using System;
using Fuel.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Fuel.Migrations
{
    [DbContext(typeof(FuelDbContext))]
    partial class FuelDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.3-servicing-35854");

            modelBuilder.Entity("Fuel.Data.FuelStop", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<double>("distanceTravelled");

                    b.Property<double>("price");

                    b.Property<double>("stopAmount");

                    b.Property<DateTime>("stopDate");

                    b.HasKey("id");

                    b.ToTable("Stops");
                });
#pragma warning restore 612, 618
        }
    }
}
