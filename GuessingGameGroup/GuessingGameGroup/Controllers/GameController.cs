using GuessingGameGroup.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GuessingGameGroup.Controllers
{
    public class GameController : Controller
    {
        // GET: Game
        public ActionResult Index()
        {
            Session["answer"] = new Random().Next(1, 25);
            
            return View();
        }

        private bool GuessWasCorrect(int guess) =>
            guess == (int)Session["answer"];

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(Game model)
        {
            if (ModelState.IsValid)
            {
                ViewBag.Victory = GuessWasCorrect(model.Number);

            }
            return View(model);
        }
    }
}