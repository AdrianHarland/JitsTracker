﻿// <auto-generated />
using JitsTrackerBE.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace JitsTrackerBE.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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

                    b.HasIndex("TechniqueId");

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

            modelBuilder.Entity("JitsTrackerBE.Data.Enitities.MoveEntity", b =>
                {
                    b.HasOne("JitsTrackerBE.Data.Enitities.TechniqueEntity", "Technique")
                        .WithMany("Moves")
                        .HasForeignKey("TechniqueId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Technique");
                });

            modelBuilder.Entity("JitsTrackerBE.Data.Enitities.TechniqueEntity", b =>
                {
                    b.Navigation("Moves");
                });
#pragma warning restore 612, 618
        }
    }
}
