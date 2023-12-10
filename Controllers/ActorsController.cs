using e_Tickets.Models;
using e_Tickets.Repository;
using Microsoft.AspNetCore.Mvc;

namespace e_Tickets.Controllers
{
    public class ActorsController : Controller
    {
        private readonly IGenericRepository<Actor> context;

        public ActorsController(IGenericRepository<Actor> _context)
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
