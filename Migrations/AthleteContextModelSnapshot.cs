﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Test.api.Models;

namespace Test.api.Migrations
{
    [DbContext(typeof(AthleteContext))]
    partial class AthleteContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.2-servicing-10034");

            modelBuilder.Entity("Test.api.Models.Athlete", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Country");

                    b.Property<string>("Name");

                    b.Property<DateTime>("Time");

                    b.HasKey("ID");

                    b.ToTable("Athletes");
                });
#pragma warning restore 612, 618
        }
    }
}