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
            var cinemas = await context.Getall();
            return View(cinemas);
        }
        #region Create New Cinema Action
        [HttpGet]
        public IActionResult Create()
        {
            return View(new Cinema());
        }
        [HttpPost]
        public async Task<IActionResult> Create(Cinema cinema)
        {
            if (ModelState.IsValid)
            {
                await context.Add(cinema);
                return RedirectToAction("Index");
            }
            else
            {
                return View(cinema);
            }
        }
        #endregion

        #region Update Current Cinema Action
        [HttpGet]
        public async Task<IActionResult> Update(int id)
        {
            var found = await context.GetById(id);
            if (found is not null)
            {
                return View(found);
            }
            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> Update(int id, Cinema cinema)
        {
            if (ModelState.IsValid)
            {
                await context.Update(id, cinema);
                return RedirectToAction("index");
            }
            else
            {
                return View(cinema);
            }
        }
        #endregion

        #region Delate Cinema Action
        public async Task<IActionResult> Delete(int id)
        {
            var found = await context.GetById(id);
            if (found != null)
            {
                await context.Delete(id);
                return RedirectToAction("Index");
            }
            return RedirectToAction("Index");
        } 
        #endregion
    }
}
