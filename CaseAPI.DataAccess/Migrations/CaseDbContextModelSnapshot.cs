﻿// <auto-generated />
using CaseAPI.DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CaseAPI.DataAccess.Migrations
{
    [DbContext(typeof(CaseDbContext))]
    partial class CaseDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("CaseAPI.Entities.Boat", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Color")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<decimal>("Length")
                        .HasColumnType("decimal(18,2)");

                    b.Property<bool>("WithSail")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("Id");

                    b.ToTable("Boats");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Color = "orange",
                            Length = 3.7m,
                            WithSail = true
                        },
                        new
                        {
                            Id = 2,
                            Color = "pink",
                            Length = 12.6m,
                            WithSail = true
                        },
                        new
                        {
                            Id = 3,
                            Color = "brown",
                            Length = 7.6m,
                            WithSail = false
                        },
                        new
                        {
                            Id = 4,
                            Color = "black",
                            Length = 1.2m,
                            WithSail = false
                        });
                });

            modelBuilder.Entity("CaseAPI.Entities.Bus", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Capacity")
                        .HasColumnType("int");

                    b.Property<string>("Color")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<bool>("Headlights")
                        .HasColumnType("bit");

                    b.Property<int>("Wheels")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Id");

                    b.ToTable("Buses");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Capacity = 27,
                            Color = "blue",
                            Headlights = true,
                            Wheels = 6
                        },
                        new
                        {
                            Id = 2,
                            Capacity = 9700,
                            Color = "yellow",
                            Headlights = false,
                            Wheels = 8
                        },
                        new
                        {
                            Id = 3,
                            Capacity = 16,
                            Color = "indigo",
                            Headlights = true,
                            Wheels = 4
                        },
                        new
                        {
                            Id = 4,
                            Capacity = 27,
                            Color = "blue",
                            Headlights = false,
                            Wheels = 6
                        });
                });

            modelBuilder.Entity("CaseAPI.Entities.Car", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Color")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<bool>("Headlights")
                        .HasColumnType("bit");

                    b.Property<int>("Wheels")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Id");

                    b.ToTable("Cars");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Color = "black",
                            Headlights = true,
                            Wheels = 4
                        },
                        new
                        {
                            Id = 2,
                            Color = "yellow",
                            Headlights = false,
                            Wheels = 4
                        },
                        new
                        {
                            Id = 3,
                            Color = "blue",
                            Headlights = true,
                            Wheels = 4
                        },
                        new
                        {
                            Id = 4,
                            Color = "yellow",
                            Headlights = false,
                            Wheels = 4
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
