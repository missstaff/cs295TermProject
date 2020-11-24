using StephenKingFanSite.Data;
using StephenKingFanSite.Models;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace StephenKingFanSite.Repos
{
    public class MovieRepo : IMovieRepo
    {
        KingContext context;

        public MovieRepo(KingContext c)
        {
            context = c;
        }
        public async Task<int> AddMoviesAsync(Movie movie)
        {
            context.Movies.Add(movie);
            return await context.SaveChangesAsync();
        }

        public async Task<int> DeleteMoviesAsync(int? id)
        {
            var movie = context.Movies.Find(id);
            context.Movies.Remove(movie);
            return await context.SaveChangesAsync();
        }

        public async Task<IQueryable<Movie>> GetAllMoviesAsync()
        {
            return await Task.FromResult<IQueryable<Movie>>(context.Movies);
        }

        public async Task<Movie> GetMoviesAsync(int? id)
        {
            return await Task.FromResult<Movie>(context.Movies.Find(id));
        }


        public bool MoviesExists(int id)
        {
            var movie = GetMoviesAsync(id);
            if (movie != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public Task SaveChangesAsync()
        {
            return SaveChangesAsync();
        }

        public void UpdateMoviesAsync(Movie movie, int id)
        {
            var m = context.Movies.Find(id);
            m.Title = movie.Title;
            m.Director = movie.Director;
            m.PremiereDate = m.PremiereDate;
            m.Genre = m.Genre;
            m.Rating = movie.Rating;
           // context.Movies.Update(movie);// not sure I need that
            context.SaveChangesAsync();
        }
    }
}
