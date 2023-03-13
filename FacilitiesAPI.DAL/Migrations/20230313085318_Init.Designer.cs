﻿// <auto-generated />
using System;
using FacilitiesAPI.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace FacilitiesAPI.DAL.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20230313085318_Init")]
    partial class Init
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("FacilitiesAPI.Domain.Models.TankEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<int?>("MaxVolume")
                        .HasColumnType("integer");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<int?>("UnitId")
                        .HasColumnType("integer");

                    b.Property<int?>("Volume")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("UnitId");

                    b.ToTable("Tanks");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Надземный - вертикальный",
                            MaxVolume = 2000,
                            Name = "Резервуар 1",
                            UnitId = 1,
                            Volume = 1500
                        },
                        new
                        {
                            Id = 2,
                            Description = "Надземный - горизонтальный",
                            MaxVolume = 3000,
                            Name = "Резервуар 2",
                            UnitId = 1,
                            Volume = 2500
                        },
                        new
                        {
                            Id = 3,
                            Description = "Надземный - горизонтальный",
                            MaxVolume = 3000,
                            Name = "Дополнительный резервуар 24",
                            UnitId = 2,
                            Volume = 3000
                        },
                        new
                        {
                            Id = 4,
                            Description = "Надземный - вертикальный",
                            MaxVolume = 3000,
                            Name = "Резервуар 35",
                            UnitId = 2,
                            Volume = 3000
                        },
                        new
                        {
                            Id = 5,
                            Description = "Подземный - двустенный",
                            MaxVolume = 5000,
                            Name = "Резервуар 47",
                            UnitId = 2,
                            Volume = 4000
                        },
                        new
                        {
                            Id = 6,
                            Description = "Подводный",
                            MaxVolume = 500,
                            Name = "Резервуар 256",
                            UnitId = 3,
                            Volume = 500
                        });
                });

            modelBuilder.Entity("FacilitiesAPI.Domain.Models.UnitEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Units");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Газофракционирующая установка",
                            Name = "ГФУ-2"
                        },
                        new
                        {
                            Id = 2,
                            Description = "Атмосферно-вакуумная трубчатка",
                            Name = "АВТ-6"
                        },
                        new
                        {
                            Id = 3,
                            Description = "Атмосферно-вакуумная трубчатка",
                            Name = "АВТ-10"
                        });
                });

            modelBuilder.Entity("FacilitiesAPI.Domain.Models.TankEntity", b =>
                {
                    b.HasOne("FacilitiesAPI.Domain.Models.UnitEntity", "Unit")
                        .WithMany()
                        .HasForeignKey("UnitId");

                    b.Navigation("Unit");
                });
#pragma warning restore 612, 618
        }
    }
}