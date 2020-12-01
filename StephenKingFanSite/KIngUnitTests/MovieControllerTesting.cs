using StephenKingFanSite.Controllers;
using StephenKingFanSite.Models;
using StephenKingFanSite.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace KIngUnitTests
{
    public class MovieControllerTesting
    {
        DateTime dt = new DateTime(2021, 01, 01);
        [Fact]
        public async Task DeleteMethodAsync()
        {
            var repo = new FakeMovieRepo();
            var controller = new MoviesController(repo);
            repo.Movies.Add(new Movie()
            {
                ID = 1,
                Title = "test",
                Director = "director",
                PremiereDate = dt,
                Genre = "H",
                Rating = 5
            });
            repo.Movies.Add(new Movie()
            {
                ID = 2,
                Title = "mest",
                Director = "author",
                PremiereDate = dt,
                Genre = "S",
                Rating = 3
            });
            repo.Movies.Add(new Movie()
            {
                ID = 3,
                Title = "pest3",
                Director = "publisher",
                PremiereDate = dt,
                Genre = "T",
                Rating = 4
            });

            bool deleted = true;
            var movies = repo.Movies.ToList();
            await controller.Delete(1);
            await Task.FromResult(controller.DeleteConfirmed(1));
            Assert.True(deleted);
        }

        [Fact]
        public async Task UpdateMethodAsync()
        {
            var repo = new FakeMovieRepo();
            var controller = new MoviesController(repo);
            repo.Movies.Add(new Movie()
            {
                ID = 1,
                Title = "test",
                Director = "director",
                PremiereDate = dt,
                Genre = "H",
                Rating = 5
            });
            repo.Movies.Add(new Movie()
            {
                ID = 2,
                Title = "mest",
                Director = "author",
                PremiereDate = dt,
                Genre = "S",
                Rating = 3
            });
            repo.Movies.Add(new Movie()
            {
                ID = 3,
                Title = "pest3",
                Director = "publisher",
                PremiereDate = dt,
                Genre = "T",
                Rating = 4
            });

            var movies = repo.Movies.ToList();
            var movie = movies.ElementAt(2);
            movie.Title = "Updated";
            await Task.FromResult(controller.Edit(3));
            Assert.Equal("Updated", movie.Title);
        }
    }
}
