﻿// <auto-generated />
using JitsTrackerBE.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace JitsTrackerBE.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20241202120935_test")]
    partial class test
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("JitsTrackerBE.Data.Enitities.MoveEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("MoveName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("TechniqueId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Moves");
                });

            modelBuilder.Entity("JitsTrackerBE.Data.Enitities.TechniqueEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("TechniqueName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Techniques");
                });
#pragma warning restore 612, 618
        }
    }
}