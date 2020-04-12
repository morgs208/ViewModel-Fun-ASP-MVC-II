using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ViewModelFun.Models;

namespace ViewModelFun.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            ViewBag.message = "this is a message for all the homies";
            return View();
        }

        [HttpGet("user")]
        public IActionResult User()
        {
            User currentUser = new User()
            {
                FirstName = "Morgan",
                LastName = "Bloom"
            };
            return View(currentUser);
        }

        [HttpGet("numbers")]
        public IActionResult Numbers()
        {
           int[] numbers = new int[] {45, 78 ,4,7,12};
           return View(numbers);
        }
        [HttpGet("users")]
        public IActionResult Users()
    {
        User user1 = new User()
        {
            FirstName = "Sally",
            LastName = "Smith"
        };
          User user2 = new User()
        {
            FirstName = "Max",
            LastName = "Brown"
        };
          User user3 = new User()
        {
            FirstName = "Debbie",
            LastName = "Downer"
        };
        List<User> ViewModel = new List<User>()
        {
            user1, user2, user3
        };

        return View(ViewModel);
    }
   
    }
}
