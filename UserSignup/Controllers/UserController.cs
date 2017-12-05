using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using UserSignup.Models;
using UserSignup.ViewModels;

namespace UserSignup.Controllers
{
    public class UserController : Controller
    {
        static private List<User> userList = new List<User>();

        public IActionResult Index()
        {
            return View(userList);
        }

        public IActionResult Add()
        {
            AddUserViewModel newUser = new AddUserViewModel();
            return View(newUser);
        }

        [HttpPost]
        public IActionResult Add(AddUserViewModel addUserViewModel)
        {
            if (ModelState.IsValid)
            {
                User newUser = new User
                {
                    Username = addUserViewModel.Username,
                    Email = addUserViewModel.Email,
                    Password = addUserViewModel.Password,
                };

                userList.Add(newUser);

                return Redirect("/");
            }
            return View(addUserViewModel);
        }
    }
}