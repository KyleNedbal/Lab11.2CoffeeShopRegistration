using Lab11._2CoffeeShopRegistration.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab11._2CoffeeShopRegistration.Controllers
{
    public class ResultController : Controller
    {
        [HttpPost]
        public IActionResult Index(User user)
        {
            Models.User.currentUser = user;
            return View(user);
        }

        public IActionResult Profile()
        {
            return View(Models.User.currentUser);
        }
    }
}
