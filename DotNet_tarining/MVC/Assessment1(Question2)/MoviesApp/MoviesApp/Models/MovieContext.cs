using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MoviesApp.Models
{
    public class MovieContext:DbContext
    {
        public MovieContext() : base("name=MovieConnection") { }
        public DbSet<Movie> Movies { get; set; }
    }
}