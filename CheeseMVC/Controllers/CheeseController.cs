﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CheeseMVC.Controllers
{
    public class CheeseController : Controller
    {
        static private Dictionary<string,string> CheeseList = new Dictionary<string,string>();  // 'static' means that the property (CheeseList) is available to all methods inside the CheeseController class.

        public IActionResult Index()
        {
            ViewBag.cheeses = CheeseList;

            return View();  //View() tells the program to search the Views/Cheese and Views/Shared folders for a template called "Index.cshtml".
                            //By passing in the parameter like View("Error"), the program will search the Views folders for the specified filename.
        }

        [HttpGet]
        public IActionResult Add()
        {

            return View();
        }

        [Route("/Cheese/Add")]
        [HttpPost]
        public IActionResult NewCheese(string name, string info)
        {
            CheeseList.Add(name,info);
            return Redirect("/Cheese");
        }

        [HttpGet]
        public IActionResult Remove()
        {
            ViewBag.cheeses = CheeseList;
            return View();
        }

        [Route("/Cheese/Remove")]
        [HttpPost]
        public IActionResult EatCheese(string eaten)
        {
            CheeseList.Remove(eaten);
            return Redirect("/Cheese");
        }
    }
}