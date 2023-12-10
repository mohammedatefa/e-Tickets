using e_Tickets.Models;
using e_Tickets.Repository;
using Microsoft.AspNetCore.Mvc;

namespace e_Tickets.Controllers
{
    public class ProducersController : Controller
    {
        private readonly IGenericRepository<Producer> context;

        public ProducersController(IGenericRepository<Producer> _context)
        {
            context = _context;
        }
        public async Task <IActionResult> Index()
        {
            var data = await context.Getall();
            return View();
        }
    }
}
