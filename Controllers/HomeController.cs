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
            ViewBag.Categories = context.Categories.ToList();
            return View("Movies");
        }
        //submit new movie
        [HttpPost]
        public IActionResult AddMovies(Movie movie)
        {
            context.Add(movie);
            context.SaveChanges();
            return RedirectToAction("AllMovies");
        }

        [HttpGet]
        public IActionResult AllMovies()
        {
            var AllMovies = context.Movie.ToList();
            return View(AllMovies);
        }


        //loadingthe screen to edit the ovie
        [HttpGet]
        public IActionResult Edit( int MovieID)
        {
            Movie movie = context.Movie.Single(x => x.MovieID == MovieID);
            ViewBag.Categories = context.Categories.ToList();

            return View("Movies", movie);
        }

        //Submitting the edited movie
        [HttpPost]
        public IActionResult Edit(Movie updatedMovie)
        {
            context.Update(updatedMovie);
            context.SaveChanges();

            return RedirectToAction("AllMovies");
        }


        //Delete method that receives movieID, and then redirects to all movies
        [HttpGet]
        public IActionResult Delete(int MovieID)
        {
            Movie movie = context.Movie.Single(x => x.MovieID == MovieID);

            context.Movie.Remove(movie);
            context.SaveChanges();

            return RedirectToAction("AllMovies");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
