﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Teryt.WebApi.Data;

#nullable disable

namespace Teryt.WebApi.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Teryt.WebApi.Models.SIMC", b =>
                {
                    b.Property<int>("GminaId")
                        .HasColumnType("int");

                    b.Property<int>("MzNumer")
                        .HasColumnType("int");

                    b.Property<string>("Nazwa")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PowiatId")
                        .HasColumnType("int");

                    b.Property<int>("RmNumer")
                        .HasColumnType("int");

                    b.Property<int>("RodzGminaId")
                        .HasColumnType("int");

                    b.Property<DateTime>("StanNa")
                        .HasColumnType("datetime2");

                    b.Property<int>("SymNumer")
                        .HasColumnType("int");

                    b.Property<int>("SymPod")
                        .HasColumnType("int");

                    b.Property<int>("WojewodztwoId")
                        .HasColumnType("int");

                    b.ToTable("SIMCs");
                });

            modelBuilder.Entity("Teryt.WebApi.Models.TERC", b =>
                {
                    b.Property<int?>("GminaId")
                        .HasColumnType("int");

                    b.Property<string>("Nazwa")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NazwaTerytorialna")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PowiatId")
                        .HasColumnType("int");

                    b.Property<int?>("RodzGminaId")
                        .HasColumnType("int");

                    b.Property<DateTime>("StanNa")
                        .HasColumnType("datetime2");

                    b.Property<int>("WojewodztwoId")
                        .HasColumnType("int");

                    b.ToTable("TERCs");
                });

            modelBuilder.Entity("Teryt.WebApi.Models.ULIC", b =>
                {
                    b.Property<int>("GminaId")
                        .HasColumnType("int");

                    b.Property<int>("PowiatId")
                        .HasColumnType("int");

                    b.Property<int>("RodzGminaId")
                        .HasColumnType("int");

                    b.Property<int>("SymNumer")
                        .HasColumnType("int");

                    b.Property<int>("SymNumerUlicy")
                        .HasColumnType("int");

                    b.Property<int>("WojewodztwoId")
                        .HasColumnType("int");

                    b.ToTable("ULICs");
                });
#pragma warning restore 612, 618
        }
    }
}