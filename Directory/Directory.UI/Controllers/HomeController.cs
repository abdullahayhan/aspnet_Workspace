using Directory.BLL.RepositoryPattern.Interfaces;
using Directory.MODEL.Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Directory.UI.Controllers
{
    public class HomeController : Controller
    {
        IPersonRepository repoPerson;
        public HomeController(IPersonRepository repoPerson)
        {
            this.repoPerson = repoPerson;
        }
        public IActionResult Directory()
        {
            List<Person> persons = repoPerson.GetActives();
            return View(persons);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Person person)
        {
            if (ModelState.IsValid)
            {
                return View(person);
            }
            repoPerson.Add(person);
            return RedirectToAction("Directory");
        }

        public IActionResult Update(int id)
        {
            Person person = repoPerson.GetById(id);
            return View(person);
        }

        [HttpPost]
        public IActionResult Update(Person person)
        {
            if (!ModelState.IsValid)
            {
                return View(person);
            }
            repoPerson.Update(person);
            return RedirectToAction("Directory");
        }

        public IActionResult Delete(int id)
        {
            repoPerson.Delete(id);
            return RedirectToAction("Directory");
        }
    }
}
