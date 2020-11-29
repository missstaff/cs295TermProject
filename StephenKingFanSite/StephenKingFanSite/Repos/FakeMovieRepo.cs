using StephenKingFanSite.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StephenKingFanSite.Repos
{
    public class FakeMovieRepo : IMovieRepo
    {

        private List<Movie> movies = new List<Movie>();

        public List<Movie> Movies { get { return movies; } }

        public Task<int> AddMoviesAsync(Movie movie)
        {
            int success = 0;
            if (movie != null)
            {
               
                movie.ID = movies.Count + 1;
                movies.Add(movie);
                success = 1;  
            }

            return Task.FromResult<int>(success);
        }

        public Task<int> DeleteMoviesAsync(int? id)
        {
            int success = 0;
            if (id != null)
            {
                var movie = movies.ElementAt((int)id);
                movies.Remove(movie);
                success = 1; 
            }

            return Task.FromResult<int>(success);
        }

        public Task<IQueryable<Movie>> GetAllMoviesAsync()
        {
            return Task.FromResult(movies.AsQueryable());
        }

        public Task<Movie> GetMoviesAsync(int? id)
        {
            return Task.FromResult(movies.ElementAt((int)id));
        }

        //if breaks add async into name of method and add await infront of get moviesget
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
            var m = movies.Find(m => m.ID == id);
            m.Title = movie.Title;
            m.Director = movie.Director;
            m.PremiereDate = movie.PremiereDate;
            m.Genre = movie.Genre;
            m.Rating = movie.Rating;
        }
    }
}
