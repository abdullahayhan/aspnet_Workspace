using Library.Models;
using Library.RepositoryPattern.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.Controllers
{
    public class AuthController : Controller
    {
        IRepository<AppUser> repoUser;
        public AuthController(IRepository<AppUser> repoUser)
        {
            this.repoUser = repoUser;
        }
        public IActionResult Login()
        {
            return View();
        }

        // veritabanında ilgili kullanıcı var mı 
        // kullanıcılarını bilgisini çek
        // kullanıcının şifresi kriptolu veriyle eşleşiyor mu 
        // kullanıcının rolune göre sayfa yönlendirmesini yap.

        [HttpPost]
        public IActionResult Login(AppUser user)
        {
            if (repoUser.Any(x=>x.UserName==user.UserName && x.Status!=Enums.DataStatus.Deleted))
            {
                AppUser selectedUser = repoUser.Default(x => x.UserName == user.UserName && 
                x.Status != Enums.DataStatus.Deleted);
                bool isValid = BCrypt.Net.BCrypt.Verify(user.Password,selectedUser.Password);
                // 2. parametre kriptolu veri , 1. parametre ise bizdeki password ikisi eşitleniyorsa true dönücek
                if (isValid)
                {
                    if (selectedUser.Role==Enums.Role.admin)
                    {
                        return RedirectToAction("Index","Home",new { area="Management"});
                    }
                    else if (selectedUser.Role==Enums.Role.user)
                    {
                        return RedirectToAction("Index", "Home");
                    }
                }
            }
            return View();
        }
    }
}
