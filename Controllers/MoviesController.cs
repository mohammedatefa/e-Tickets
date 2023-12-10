using e_Tickets.Models;
using e_Tickets.Repository;
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
            var data = await context.Getall();
            return View();
        }
    }
}
