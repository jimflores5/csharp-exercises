using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using UserSignup.Models;

namespace UserSignup.Controllers
{
    public class UserController : Controller
    {
        static private List<User> userList = new List<User>();

        public IActionResult Index()
        {
            ViewBag.users = userList;
            return View();
        }

        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(User newUser, string verify)
        {
            if (newUser.Password == verify)
            {
                userList.Add(newUser);
                ViewBag.newUser = newUser;
                return View("Index");
            }
            else
            {
                ViewBag.oops = newUser;
                ViewBag.error = "Passwords do not match.";
            }
            return View();
        }
    }
}