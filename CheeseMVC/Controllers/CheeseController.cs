using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CheeseMVC.Models;
using CheeseMVC.ViewModels;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CheeseMVC.Controllers
{
    public class CheeseController : Controller
    {
        //static private Dictionary<string,string> CheeseList = new Dictionary<string,string>();  // 'static' means that the property (CheeseList) is available to all methods inside the CheeseController class.
        //static private List<Cheese> CheeseList = new List<Cheese>();
        //These collection definitions were moved to the CheeseData model, which also contains all the data management functionality.
        //Data stuff goes in the MODEL, not the CONTROLLER.

        public IActionResult Index()
        {
            //ViewBag.cheeses = CheeseData.GetAll(); <-- Original statement for passing data into the Index View() template.
            List<Cheese> cheeses = CheeseData.GetAll();

            return View(cheeses);  //View() tells the program to search the Views/Cheese and Views/Shared folders for a template called "Index.cshtml".
                            //By passing in the parameter like View("Error"), the program will search the Views folders for the specified filename.
                            //Using View(cheeses) passes the 'cheeses' list into the View template.  Note that you can only pass ONE object into the View().
        }

        [HttpGet]
        public IActionResult Add()
        {
            AddCheeseViewModel newCheese = new AddCheeseViewModel();
            return View(newCheese);
        }

        [HttpPost]
        public IActionResult Add(AddCheeseViewModel addCheeseViewModel)
        {
            //Cheese newCheese = new Cheese(name, info); Replaced by model binding.
            //public IActionResult Add(Cheese newCheese) <--Model binding occurs here.  Instead of fetching 'name' and 'info' strings from the post request and creating a new Cheese object, the program does this automatically.

            if (ModelState.IsValid)
            {
                Cheese newCheese = new Cheese
                {
                    Name = addCheeseViewModel.Name,
                    Info = addCheeseViewModel.Info,
                    Type = addCheeseViewModel.Type
                };

                CheeseData.Add(newCheese);

                return Redirect("/Cheese");
            }
            return View(addCheeseViewModel);
        }


        [HttpGet]
        public IActionResult Remove()
        {
            ViewBag.title = "Remove a cheese...";
            ViewBag.cheeses = CheeseData.GetAll();
            return View();
        }

        [Route("/Cheese/Remove")]
        [HttpPost]
        public IActionResult EatCheese(int[] cheeseIds) //Receives an array of ID integers from the Remove view form (checkboxes).
        {
            foreach (int cheeseId in cheeseIds)
            {
                CheeseData.Remove(cheeseId);
            }
   
            return Redirect("/");
        }

        public IActionResult Edit(int cheeseId)
        {
            ViewBag.editCheese = CheeseData.GetById(cheeseId);
            return View();
        }

        [HttpPost]
        public IActionResult Edit(int cheeseId, string name, string info)
        {
            Cheese changedCheese = CheeseData.GetById(cheeseId);
            changedCheese.Name = name;
            changedCheese.Info = info;
            return Redirect("/");
        }
    }
}
