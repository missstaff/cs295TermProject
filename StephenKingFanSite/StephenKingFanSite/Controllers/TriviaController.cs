using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using StephenKingFanSite.Data;
using StephenKingFanSite.Models;
using StephenKingFanSite.Repos;

namespace StephenKingFanSite.Controllers
{
    public class TriviaController : Controller
    {
        /*ITrivia repo;
        public TriviaController(ITrivia r)
        {
            repo = r;
        }*/
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(TriviaMV quiz)
        {
            quiz.CheckAnswers();
            return View(quiz);
        }
    }
}
