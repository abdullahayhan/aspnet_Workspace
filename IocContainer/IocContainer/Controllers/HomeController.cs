using IocContainer.Services;
using IocContainer.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IocContainer.Controllers
{
    public class HomeController : Controller
    {
        //ConsoleLogger _log;
        ILog _log;
        public HomeController(ILog log)
        {
            _log = log;
        }
        public string Index([FromServices] ILog log)
        {
            log.Info("action bazlı bir talep gelmiştir");
            return "Service Running";
        }
    }
}
