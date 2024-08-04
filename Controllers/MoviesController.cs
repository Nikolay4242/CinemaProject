using Microsoft.AspNetCore.Mvc;
using CinemaProject.Models;
using System.Collections.Generic;

namespace CinemaProject.Controllers
{
    public class MoviesController : Controller
    {
        public IActionResult Index()
        {
            var movies = new List<Movie>
            {
                new Movie { Title = "Movie 1", Director = "Director 1", Year = 1980, Description = "Description 1" },
                new Movie { Title = "Movie 2", Director = "Director 2", Year = 1990, Description = "Description 2" }
            };
            return View(movies);
        }

        public IActionResult Details(string title)
        {
            var movie = new Movie
            {
                Title = "Movie 1",
                Director = "Director 1",
                Year = 1980,
                Description = "Description 1",
                Sessions = new List<Session>
                {
                    new Session { Date = DateTime.Now, Time = "12:00", MovieTitle = "Movie 1", Price = 10.99m }
                }
            };
            return View(movie);
        }
    }
}
