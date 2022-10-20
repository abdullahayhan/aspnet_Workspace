using Interfaces.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Interfaces.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            MsSqlOperation msSql = new MsSqlOperation();
            msSql.Connection();

            ISqlOperation sql = new MsSqlOperation();
            sql.Connection();
            ISqlOperation mySql = new MySqlOperation();
            mySql.Connection();
            return View();
        }
    }
}
