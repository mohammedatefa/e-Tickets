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
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var data = await context.Getall();
            return View(data);
        }

        #region Create New Actor Action
        [HttpGet]
        public IActionResult Create()
        {
            return View(new Actor());
        }
        [HttpPost]
        public async Task<IActionResult> Create(Actor actor)
        {
            if (ModelState.IsValid)
            {
                await context.Add(actor);
                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }
        }
        #endregion

        #region Update Current Actor Action
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
        public async Task<IActionResult> Update(int id, Actor actor)
        {
            if (ModelState.IsValid)
            {
                await context.Update(id, actor);
                return RedirectToAction("Index");
            }
            else
            {
                return View(actor);
            }
        }
        #endregion

        #region Delete Actor Action
        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            var found = context.GetById(id);
            if (found != null)
            {
                await context.Delete(id);
                return RedirectToAction("Index");
            }
            else
            {
                return RedirectToAction("Index");
            }
        } 
        #endregion
    }
}
