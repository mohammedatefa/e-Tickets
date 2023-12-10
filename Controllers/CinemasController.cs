using e_Tickets.Models;
using e_Tickets.Repository;
using Microsoft.AspNetCore.Mvc;

namespace e_Tickets.Controllers
{
    public class CinemasController : Controller
    {
        private readonly IGenericRepository<Cinema> context;

        public CinemasController(IGenericRepository<Cinema> _context)
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
