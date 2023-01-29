﻿// <auto-generated />
using System;
using HakatoApi.DBContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace HakatoApi.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20230124191108_Secnd")]
    partial class Secnd
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("HakatoApi.Models.Doctor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Direction")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("First_name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Last_name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Worklocation")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("price")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("doctor");
                });

            modelBuilder.Entity("HakatoApi.Models.Patient", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("ID"));

                    b.Property<string>("Direction")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("First_name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("HomeLocation")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Last_name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("born")
                        .HasColumnType("timestamp with time zone");

                    b.Property<bool>("gender")
                        .HasColumnType("boolean");

                    b.Property<bool>("patient")
                        .HasColumnType("boolean");

                    b.HasKey("ID");

                    b.ToTable("patient");
                });
#pragma warning restore 612, 618
        }
    }
}