using System;
using System.Linq;
using StephenKingFanSite.Models;

namespace StephenKingFanSite.Data
{
    public class DbInitializer
    {
        public static void Initialize(KingContext context)
        {
            context.Database.EnsureCreated();

            // Look for any Users.
            if (context.Users.Any())
            {
                return;   // DB has been seeded
            }

            var users = new User[]
           {
            new User{Name="Shawna"},
            new User{Name="Ivy"}
           };
            foreach (User u in users)
            {
                context.Users.Add(u);
            }
            context.SaveChanges();

            var forums = new Forum[]
            {
            new Forum{Topic="Rose Red",Comments="I loved this movie!",Name="Shawna",Date=DateTime.Parse("2020-11-10")},
            new Forum{Topic="1408",Comments="This movie was a trip",Name="Ivy",Date=DateTime.Parse("2020-11-10")}
            };
            foreach (Forum f in forums)
            {
                context.Forums.Add(f);
            }
            context.SaveChanges();

            var movies = new Movie[]
            {
            new Movie{Title="1408",Director="Mikael Håfström",PremiereDate=DateTime.Parse("2007-06-02"),Genre="S",Rating=5},
            new Movie{Title="Cat's Eye",Director="Lewis Teague",PremiereDate=DateTime.Parse("1985-04-12"),Genre="H",Rating=5},
            new Movie{Title="Cell",Director="Tod Williams",PremiereDate=DateTime.Parse("2016-05-19"),Genre="S",Rating=5},
            new Movie{Title="Creep Show",Director="George A. Romero",PremiereDate=DateTime.Parse("1982-11-12"),Genre="H",Rating=5},
            new Movie{Title="Pet Cematary",Director="Mary Lambert",PremiereDate=DateTime.Parse("1989-04-21"),Genre="H",Rating=5}
            };
            foreach (Movie m in movies)
            {
                context.Movies.Add(m);
            }
            context.SaveChanges();

            var novels = new Novel[]
            {
            new Novel{Title="Bag Of Bones",Publisher="Scribner",PulicationDate=DateTime.Parse("1998-09-22"),Genre="H",Rating=5},
            new Novel{Title="Dream Catcher",Publisher="Scribner",PulicationDate=DateTime.Parse("2001-02-20"),Genre="SF",Rating=5},
            new Novel{Title="Firestarter",Publisher="Viking Press",PulicationDate=DateTime.Parse("1980-09-29"),Genre="T",Rating=5},
            new Novel{Title="Salem's Lot",Publisher="Doubleday",PulicationDate=DateTime.Parse("1975-10-07"),Genre="H",Rating=5},
            new Novel{Title="The Tommy Knockers",Publisher="G.P. Putnam's & Sons",PulicationDate=DateTime.Parse("1987-11-01"),Genre="SF",Rating=5}
            };
            foreach (Novel n in novels)
            {
                context.Novels.Add(n);
            }
            context.SaveChanges();

            var genres = new Genre[]
            {
            new Genre{Code="C", Name="Crime"},
            new Genre{Code="D", Name="Drama"},
            new Genre{Code="F", Name="Fantasy"},
            new Genre{Code="H", Name="Horror"},
            new Genre{Code="S", Name="Suspense"},
            new Genre{Code="SF", Name="Sci-Fi"},
            new Genre{Code="T", Name="Thriller"}
            };
            foreach (Genre g in genres)
            {
                context.Genres.Add(g);
            }
            context.SaveChanges();
        }
    }
}
