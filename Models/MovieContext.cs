using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission4.Models
{
    public class MovieContext: DbContext
    {

        // set up standard options for context
        public MovieContext (DbContextOptions<MovieContext> options): base(options)
        {

        }

        // name of the table
        public DbSet<Movie> Movie { get; set; }
        public DbSet<Categories> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {

            mb.Entity<Categories>().HasData(
                new Categories { categoryID = 1, categoryName = "Comedy" },
                new Categories { categoryID = 2, categoryName = "Drama" },
                new Categories { categoryID = 3, categoryName = "Horror" }

                );
            mb.Entity<Movie>().HasData(
                new Movie
                {
                    MovieID = 1,
                    title = "Incredibles",
                    categoryID = 1,
                    rating = "PG-13",
                    director = "Quentin",
                    edited = false,
                    year = 2009,
                    lentTo = "Bob",
                    notes = "Very Good"
                },
                new Movie
                {
                    MovieID = 2,
                    title = "Wahtever",
                    categoryID = 1,
                    rating = "PG-13",
                    director = "Jack Black",
                    edited = true,
                    year = 2109,
                    lentTo = "Bob",
                    notes = ""
                },
                new Movie
                {
                    MovieID = 3,
                    title = "Yeet",
                    categoryID = 1,
                    rating = "R",
                    director = "Other",
                    edited = true,
                    year = 2009,
                    lentTo = "Jack",
                    notes = "Very Good"
                }
                );
        }
    }
}
