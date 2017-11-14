using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ViewBagPractice.Controllers
{
    public class ViewBagPracticeController : Controller
    {
        private static List<string> comics = new List<string>();

        public IActionResult Index()
        {
            comics.Add("Spiderman, Issue #1");
            comics.Add("Spiderman, Issue #2");
            comics.Add("Spiderman, Issue #3");
            ViewBag.comics = comics;

            return View();
        }

        [HttpPost]
        public IActionResult Add(string comic)
        {
            comics.Add(comic);
            return Redirect("/ViewBagPractice/Index");
        }
    }
}