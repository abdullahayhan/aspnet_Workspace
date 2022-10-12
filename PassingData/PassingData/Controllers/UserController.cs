using Microsoft.AspNetCore.Mvc;
using PassingData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PassingData.Controllers
{
    public class UserController : Controller
    {
        public IActionResult UseViewBag()
        {
            ViewBag.UserName = "Abdullah";
            User user = new User() { FirstName = "Çidem", LastName = "Ayhan" };
            ViewBag.User = user;
            List<User> users = new List<User>()
            {
                new User(){FirstName="Mert",LastName="Ayhan"},
                new User(){FirstName="Elif",LastName="Ayhan"},
                new User(){FirstName="Aşkın",LastName="Ayhan"},

            };
            ViewBag.Users = users;
            return View();
        }
    }
}
