using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Configuration.Controllers
{
    public class UserController : Controller
    {
        IConfiguration _configuration;
        public UserController(IConfiguration configuration)
        {
            configuration = _configuration;
        }
        public IActionResult Index()
        {
            string name = _configuration["User:Name"];
            return View();
        }
    }
}
