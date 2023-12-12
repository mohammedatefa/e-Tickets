using e_Tickets.Models;
using e_Tickets.Repository;
using e_Tickets.Specification;
using Microsoft.AspNetCore.Mvc;

namespace e_Tickets.Controllers
{
    public class MoviesController : Controller
    {
        private readonly IGenericRepository<Movies> context;

        public MoviesController(IGenericRepository<Movies> _context)
        {
            context = _context;
        }
        public async Task<IActionResult> Index()
        {
            //using specification to get movies with the cinema
            var spec = new MoviesWithCinema();
            var movies = await context.GetAllWithSpec(spec);
            return View(movies);
        }
    }
}
