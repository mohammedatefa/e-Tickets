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
            var producers = await context.Getall();
            return View(producers);
        }
        #region Create New Producer Action
        [HttpGet]
        public IActionResult Create()
        {
            return View(new Producer());
        }
        [HttpPost]
        public async Task<IActionResult> Create(Producer producer)
        {
            if (ModelState.IsValid)
            {
                await context.Add(producer);
                return RedirectToAction("Index");
            }
            else
            {
                return View(producer);
            }
        } 
        #endregion

        #region Update Current Producer Action
        [HttpGet]
        public async Task<IActionResult> Update(int id)
        {
            var found = await context.GetById(id);
            if (found is not null)
            {
                return View(found);
            }
            else
            {
                return RedirectToAction("Index");
            }
        }
        [HttpPost]
        public async Task<IActionResult> Update(int id, Producer producer)
        {
            if (ModelState.IsValid)
            {
                await context.Update(id, producer);
                return RedirectToAction("Index");
            }
            else
            {
                return View(producer);
            }
        } 
        #endregion

        #region Delete Prducer Action
        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            var found = await context.GetById(id);
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
