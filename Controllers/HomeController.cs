using eTickets.Data;
using eTickets.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace eTickets.Controllers
{
    public class HomeController : Controller
    {
        //private readonly AppContext context = new AppContext();
        private readonly ILogger<HomeController> _logger;
        private readonly AppDbContext context;

        public HomeController(ILogger<HomeController> logger, AppDbContext _context)
        {
            _logger = logger;
            context = _context;
        }

        public async Task<IActionResult> Index()
        {
            var listOfMovies = await context.Movies.ToListAsync();
            return View(listOfMovies);
        }
        [HttpPost]
        public IActionResult Search([Bind("MovieName")] string name)
        {
            // ToDo: search to movies
            //var movieList = context.Movies.Where(x => x.MovieName.Contains(name) || x.Description.Contains(name)).ToList();
            List<Movie> movieList = new List<Movie>();
            return View("Index", movieList);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
