using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using StephenKingFanSite.Models;

namespace StephenKingFanSite.Controllers
{
    public class TriviaController : Controller
    {
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
