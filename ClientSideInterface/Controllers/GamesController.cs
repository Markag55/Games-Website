using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClientSideInterface.Models;

namespace ClientSideInterface.Controllers
{
    public class GamesController : Controller
    {
        private GamesContext context { get; set; }

        public GamesController(GamesContext ctx)
        {
            context = ctx;
        }

        [HttpGet]
        public IActionResult Add()
        {
            ViewBag.Action = "Add";
            ViewBag.System = context.System.OrderBy(s => s.SystemID).ToList();
            return View("Edit", new GamesModel());
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewBag.Action = "Edit";
            ViewBag.System = context.System.OrderBy(s => s.SystemID).ToList();
            var dealership = context.Games.Find(id);
            return View(dealership);
        }
        [HttpPost]
        public IActionResult Edit(GamesModel game)
        {
            if (ModelState.IsValid)
            {
                if (game.ID == 0)
                    context.Games.Add(game);
                else
                    context.Games.Update(game);
                context.SaveChanges();
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ViewBag.Action = (game.ID == 0) ? "Add" : "Edit";
                ViewBag.Games = context.Games.OrderBy(s => s.SystemID).ToList();
                return View(game);
            }
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var game = context.Games.Find(id);
            return View(game);
        }

        [HttpPost]
        public IActionResult Delete(GamesModel game)
        {
            context.Games.Remove(game);
            context.SaveChanges();
            return RedirectToAction("Index", "Home");
        }
    }

}
