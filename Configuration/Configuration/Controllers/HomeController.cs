using Configuration.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Configuration.Controllers
{
    public class HomeController : Controller
    {
        readonly IConfiguration _configuration;
        public HomeController(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public IActionResult Index()
        {
            string email = _configuration["Email"];
            string name = _configuration["User:Name"];
            string pass = _configuration.GetSection("User:Password").Value;
            User user = _configuration.GetSection("User").Get(typeof(User)) as User;
            return View();
        }
    }
}
