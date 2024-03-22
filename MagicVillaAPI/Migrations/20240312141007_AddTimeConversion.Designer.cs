﻿// <auto-generated />
using System;
using MagicVillaAPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace MagicVillaAPI.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20240312141007_AddTimeConversion")]
    partial class AddTimeConversion
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.22")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("MagicVillaAPI.Models.Villa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Amenity")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Details")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("Occupancy")
                        .HasColumnType("integer");

                    b.Property<double>("Rate")
                        .HasColumnType("double precision");

                    b.Property<int>("Surface")
                        .HasColumnType("integer");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.ToTable("Villas");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Amenity = "Sed facilisis, nibh id aliquet ultrices, ante nisi egestas turpis, euismod ornare metus urna eu neque. Etiam scelerisque elit rutrum augue sollicitudin sollicitudin.",
                            CreatedDate = new DateTime(2024, 3, 12, 15, 10, 7, 292, DateTimeKind.Local).AddTicks(3790),
                            Details = "Cras ut nunc at leo vehicula gravida sit amet sed odio. Suspendisse placerat porta urna in elementum",
                            ImageUrl = "https://images.unsplash.com/photo-1600585154340-be6161a56a0c?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=1740&q=80",
                            Name = "Chateau d'eau",
                            Occupancy = 4,
                            Rate = 12.0,
                            Surface = 300,
                            UpdatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 2,
                            Amenity = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aenean ut tincidunt ipsum. Morbi ex diam, euismod et erat viverra, aliquam malesuada risus. Etiam viverra sed elit non tempor",
                            CreatedDate = new DateTime(2024, 3, 12, 15, 10, 7, 292, DateTimeKind.Local).AddTicks(3816),
                            Details = "Mauris eget eros velit. Sed non facilisis risus, non cursus diam. Aenean gravida ac ex vitae malesuada. Integer venenatis interdum odio ut sodales.",
                            ImageUrl = "https://images.unsplash.com/photo-1600585154340-be6161a56a0c?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=1740&q=80",
                            Name = "Mon Village",
                            Occupancy = 4,
                            Rate = 12.0,
                            Surface = 500,
                            UpdatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });
#pragma warning restore 612, 618
        }
    }
}