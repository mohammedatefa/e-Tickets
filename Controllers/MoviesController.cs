using e_Tickets.Data.Enum;
using e_Tickets.Models;
using e_Tickets.Repository;
using e_Tickets.Specification;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace e_Tickets.Controllers
{
    public class MoviesController : Controller
    {
        private readonly IGenericRepository<Movies> context;
        private readonly IGenericRepository<Actor> actorRepository;
        private readonly IGenericRepository<Cinema> cinemaRepository;
        private readonly IGenericRepository<Producer> producerRepository;

        public MoviesController(IGenericRepository<Movies> _context,IGenericRepository<Actor> actorRepository, IGenericRepository<Cinema> cinemaRepository, IGenericRepository<Producer> producerRepository)
        {
            context = _context;
            this.actorRepository = actorRepository;
            this.cinemaRepository = cinemaRepository;
            this.producerRepository = producerRepository;
        }
        public async Task<IActionResult> Index()
        {
            //using specification to get movies with the cinema
            var spec = new MoviesWithCinema();
            var movies = await context.GetAllWithSpec(spec);
            return View(movies);
        }
        #region create new movie action
      
        [HttpGet]
        public async Task<IActionResult> Create()
        {
            ViewBag.Cinemas = await cinemaRepository.Getall();
            ViewBag.Producers = await producerRepository.Getall();
            ViewBag.Categories = Enum.GetValues(typeof(MovieCategory)).Cast<MovieCategory>();
            return View(new Movies());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Movies movie)
        {
            if (ModelState.IsValid)
            {
                await context.Add(movie);
                return RedirectToAction(nameof(Index)); // Redirect to movie list view
            }

            // If model state is not valid, reload the view with the model
            ViewBag.Cinemas = await cinemaRepository.Getall();
            ViewBag.Producers = await producerRepository.Getall();
            ViewBag.Categories = Enum.GetValues(typeof(MovieCategory)).Cast<MovieCategory>();
            return View(movie);
        }
        #endregion

        [HttpGet]
        public async Task<IActionResult> Update(int id)
        {
            var found =await context.GetById(id);
            ViewBag.Cinemas = await cinemaRepository.Getall();
            ViewBag.Producers = await producerRepository.Getall();
            ViewBag.Categories = Enum.GetValues(typeof(MovieCategory)).Cast<MovieCategory>();
            return View(found);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int id,Movies movie)
        {
            if (ModelState.IsValid)
            {
                await context.Update(id, movie);
                return RedirectToAction("Index");
            }
            ViewBag.Cinemas = await cinemaRepository.Getall();
            ViewBag.Producers = await producerRepository.Getall();
            ViewBag.Categories = Enum.GetValues(typeof(MovieCategory)).Cast<MovieCategory>();
            return View();
        }
    }
}
