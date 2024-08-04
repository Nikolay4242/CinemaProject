using Microsoft.AspNetCore.Mvc;
using CinemaProject.Models;
using System.Collections.Generic;

namespace CinemaProject.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var sessions = new List<Session>
            {
                new Session { Date = DateTime.Now, Time = "12:00", MovieTitle = "Movie 1", Price = 10.99m },
                new Session { Date = DateTime.Now, Time = "15:00", MovieTitle = "Movie 2", Price = 12.99m }
            };
            return View(sessions);
        }
    }
}
