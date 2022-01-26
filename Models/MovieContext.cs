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
    }
}
