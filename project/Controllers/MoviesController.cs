using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using project.Data;
using project.Models.Movies;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace project.Controllers
{
    public class MoviesController : Controller
    {
        private readonly MoviesContext _dbContext;

        public MoviesController(MoviesContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IActionResult> Index()
        {
            var movies = await _dbContext.Movies.ToListAsync();
            return View(movies);
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Add(Movie movie)
        {


            _dbContext.Movies.Add(movie);
            await _dbContext.SaveChangesAsync();

            var movies = await _dbContext.Movies.ToListAsync();

            return View("Index", movies);
        }

        public async Task<IActionResult> Search(string text)
        {
            text = text.ToLower();
            var searchedMovies = await _dbContext.Movies.Where(movie => movie.Name.ToLower().Contains(text)
                                            || movie.Genre.ToLower().Contains(text)
                                            || movie.Author.ToLower().Contains(text))
                                        .ToListAsync();
            return View("Index", searchedMovies);
        }
    }
}
