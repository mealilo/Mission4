﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Mission4.Models;

namespace Mission4.Migrations
{
    [DbContext(typeof(MovieContext))]
    [Migration("20220127005736_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.13");

            modelBuilder.Entity("Mission4.Models.Movie", b =>
                {
                    b.Property<int>("MovieID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("category")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("director")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("edited")
                        .HasColumnType("INTEGER");

                    b.Property<string>("lentTo")
                        .HasColumnType("TEXT");

                    b.Property<string>("notes")
                        .HasMaxLength(25)
                        .HasColumnType("TEXT");

                    b.Property<string>("rating")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("year")
                        .HasColumnType("INTEGER");

                    b.HasKey("MovieID");

                    b.ToTable("Movie");

                    b.HasData(
                        new
                        {
                            MovieID = 1,
                            category = "Action",
                            director = "Quentin",
                            edited = false,
                            lentTo = "Bob",
                            notes = "Very Good",
                            rating = "PG-13",
                            title = "Incredibles",
                            year = 2009
                        },
                        new
                        {
                            MovieID = 2,
                            category = "Comedy",
                            director = "Jack Black",
                            edited = true,
                            lentTo = "Bob",
                            notes = "",
                            rating = "PG-13",
                            title = "Wahtever",
                            year = 2109
                        },
                        new
                        {
                            MovieID = 3,
                            category = "Drama",
                            director = "Other",
                            edited = true,
                            lentTo = "Jack",
                            notes = "Very Good",
                            rating = "R",
                            title = "Yeet",
                            year = 2009
                        });
                });
#pragma warning restore 612, 618
        }
    }
}