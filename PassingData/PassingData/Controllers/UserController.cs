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
        List<User> users = new List<User>()
            {
                new User(){FirstName="Mert",LastName="Ayhan"},
                new User(){FirstName="Elif",LastName="Ayhan"},
                new User(){FirstName="Aşkın",LastName="Ayhan"},

            };
        public IActionResult UseViewBag()
        {
            ViewBag.UserName = "Abdullah";
            User user = new User() { FirstName = "Çidem", LastName = "Ayhan" };
            ViewBag.User = user;
            ViewBag.Users = users;
            return View();
        }

        public IActionResult UseViewData()
        {
            ViewData["UserName"] = "Abdullah";
            User user = new User() { LastName = "Ayhan", FirstName = "Mert" };
            ViewData["User"] = user;
            ViewData["Users"] = users;
            return View();
        }

        public IActionResult UseTempData()
        {
            TempData["name"] = "abdullah";
            return RedirectToAction("UseTempDataTest"); // başka bir action viewı çağırma
        }

        public IActionResult UseTempDataTest()
        {
            TempData.Keep("name"); // sayfayı yenilediğinde bir daha kullanabilmek için.
            // tempdata olayı başka bir viewde kullanılabilir. Yalnızca tek bir kez kullanım hakkı var ve
            // kullanımı için nerede tanımlıysa ilk o action çalışmalıdır. yukarıdaki actionda tanımlayıp burada kullandık.
            return View();
        }
    }
}
