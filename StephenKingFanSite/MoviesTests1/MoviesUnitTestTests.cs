using NUnit.Framework;
using KIngUnitTests;
using System;
using System.Collections.Generic;
using System.Text;
using StephenKingFanSite.Repos;
using StephenKingFanSite.Controllers;
using System.Linq;
using StephenKingFanSite.Models;
using System.Threading.Tasks;

namespace KIngUnitTests.Tests
{
    [TestFixture()]
    public class MoviesUnitTestTests
    {
        DateTime dt = new DateTime(2021, 01, 01);

        [Test()]
        public async Task AddMovieAsync()
        {
            var repo = new FakeMovieRepo();
            var controller = new MoviesController(repo);
            var movies = repo.Movies.ToList();
            var movie = new Movie()
            {
                ID = 1,
                Title = "test",
                Director = "test",
                PremiereDate = dt,
                Genre = "H",
                Rating = 5

            };
            await controller.Create(movie);
            // Assert
            var retrieveMovie = repo.Movies.ToList()[0];
            Assert.AreEqual("test", retrieveMovie.Title);
        }

    }
}