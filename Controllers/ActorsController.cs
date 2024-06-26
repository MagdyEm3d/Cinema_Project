using eTickets.Data;
using eTickets.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.EntityFrameworkCore;

namespace eTickets.Controllers
{
    public class ActorsController : Controller
    {
        private readonly AppDbContext context;

        public ActorsController(AppDbContext _context)
        {
            context = _context;
        }

        public async Task<IActionResult> Index()
        {
            var allActors = await context.Actors.ToListAsync();
            return View(allActors);
        }

        public async Task<IActionResult> Details(int id = 1)
        {
            var actor = await context.Actors.FirstOrDefaultAsync(x => x.ActorId == id);
            if (actor == null)
            {
                return View("Not Found");
            }
            return View(actor);
        }

        public async Task<IActionResult> Edit(int id=1)
        {
            var actor=context.Actors.FirstOrDefault(x => x.ActorId == id);  
            if (actor == null)
            {
                return View("Not Found");
            }
            return View(actor); 
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Actor actor)
        {
          if(ModelState.IsValid)
            {
                context.Actors.Update(actor);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View("Not Found");
        }

        public async Task<IActionResult> Delete(int id)
        {
           var actor=context.Actors.FirstOrDefault(x=>x.ActorId == id);
            if(actor == null)
            {
                return View("Not Found");

            }
            context.Actors.Remove(actor);   
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Create()
        {
           return View();
        }

       [HttpPost]
        public async Task<IActionResult> Create(Actor actor)
        {
           if(ModelState.IsValid)
            {
                context.Actors.Add(actor);  
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View("Not Found");
        }


    }
}
