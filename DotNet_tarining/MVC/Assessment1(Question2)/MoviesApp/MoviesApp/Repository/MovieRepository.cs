using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MoviesApp.Models;

namespace MoviesApp.Repository
{
    public class MovieRepository
    {
        private readonly MovieContext _context;

        public MovieRepository(MovieContext context)
        {
            _context = context;
        }

        public IEnumerable<Movie> GetAll() => _context.Movies.ToList();

        public Movie GetById(int id) => _context.Movies.Find(id);

        public void Insert(Movie movie) => _context.Movies.Add(movie);

        public void Update(Movie movie)
        {
            _context.Entry(movie).State = System.Data.Entity.EntityState.Modified;
        }

        public void Delete(int id)
        {
            var movie = GetById(id);
            if (movie != null)
            {
                _context.Movies.Remove(movie);
            }
        }

        public void Save() => _context.SaveChanges();
    }
}