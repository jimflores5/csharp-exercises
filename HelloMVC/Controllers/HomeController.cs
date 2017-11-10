using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HelloMVC.Models;

namespace HelloMVC.Controllers
{
    public class HomeController : Controller
    {
        // http://localhost:8888888 (Home) will enter the Index() route by default.
        public IActionResult Index(string name) // This will take any query parameters (the stuff after the '?' in the web address and place them in the name variable.
        {

            return Content(String.Format("<h1>Rutabagas for {0}!</h1>", name), "text/html");
        }

        // http://localhost:8888888/Home/Add will will run this portion of the code.
        public IActionResult Add()
        {
            var text = "<form action = '/Home/Saved' method = 'post'>" +
                "<label>name<input type = 'text'/ name = 'name'></label>" +
                "<input type = 'submit'/>"+
                "</form>";
            return Content(text, "text/html");
        }

        [HttpPost]
        public IActionResult Saved(string name)
        {

            return Content(String.Format("<h2>Saved, {0}!</h2>", name), "text/html");
        }

        // http://localhost:8888888/Home/About will run this portion of the code.
        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        // http://localhost:8888888/Home/Contact will run this portion of the code.
        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
