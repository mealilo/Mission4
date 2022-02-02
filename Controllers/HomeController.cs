using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Mission4.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Mission4.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private MovieContext context { get; set; }

        public HomeController(MovieContext movie)
        {
            context = movie;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult MyPodcasts()
        {
            return View();
        }

        [HttpGet]
        public IActionResult AddMovies()
        {
            return View("Movies");
        }
        [HttpPost]
        public IActionResult AddMovies(Movie movie)
        {
            context.Add(movie);
            context.SaveChanges();
            return View("Movies");
        }

        [HttpGet]
        public IActionResult AllMovies()
        {
            var AllMovies = context.Movie.ToList();
            return View(AllMovies);
        }

        [HttpGet]
        public IActionResult Edit( int MovieID)
        {
            Movie movie = context.Movie.Single(x => x.MovieID == MovieID);

            return View("Movies", movie);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
