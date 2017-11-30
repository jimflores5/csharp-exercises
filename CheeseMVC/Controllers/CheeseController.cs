using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CheeseMVC.Models;

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
            ViewBag.cheeses = CheeseData.GetAll();

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
        public IActionResult NewCheese(Cheese newCheese) //Model binding occurs here.  Instead of fetching 'name' and 'info' strings from the post request and creating a new Cheese object, the program does this automatically.
        {
            //Cheese newCheese = new Cheese(name, info); Replaced by model binding.
            CheeseData.Add(newCheese);

            return Redirect("/Cheese");
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
    }
}
