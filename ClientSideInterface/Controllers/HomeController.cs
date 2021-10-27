using ClientSideInterface.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ClientSideInterface.Controllers
{
    public class HomeController : Controller
    {

        private GamesContext context { get; set; }

        public HomeController(GamesContext ctx)
        {
            context = ctx;
        }
        public IActionResult Action(GamesModel model)
        {
            var games = context.Games.Where(m => m.Genere == "Action")
               .OrderBy(m => m.Title)
               .ToList();
            return View(games);
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult RolePlaying(GamesModel model)
        {
            var games = context.Games.Where(m => m.Genere == "Role-Playing")
               .OrderBy(m => m.Title)
               .ToList();
            return View(games);
        }

        public IActionResult Simulation(GamesModel model)
        {
            var games = context.Games.Where(m => m.Genere == "Simulation")
                .OrderBy(m => m.Title)
                .ToList();
            return View(games);
        }

        public IActionResult Strategy(GamesModel model)
        {
            var games = context.Games.Where(m => m.Genere == "Strategy")
               .OrderBy(m => m.Title)
               .ToList();
            return View(games);
        }

        public IActionResult Casual(GamesModel model)
        {
            var games = context.Games.Where(m => m.Genere == "Casual")
               .OrderBy(m => m.Title)
               .ToList();
            return View(games);
        }

        public IActionResult Sports(GamesModel model)
        {
            var games = context.Games.Where(m => m.Genere == "Sport")
               .OrderBy(m => m.Title)
               .ToList();
            return View(games);
        }

        public IActionResult Search()
        {
            var games = context.Games.ToList();
            return View(games);
        }

        [HttpPost]
        public IActionResult Search(string search)
        {
            var games = context.Games.Where(m => m.Title.Contains(search)).ToList();
            return View(games);
        }

        

        public IActionResult Template(int id)
        {
            var currGame = context.Games.Where(m => m.ID == id)
                .OrderBy(m => m.Title)
                .ToList();
            return View(currGame);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
