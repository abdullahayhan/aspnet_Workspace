using GettingData.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GettingData.Controllers
{
    public class TeacherController : Controller
    {
        List<Branch> branches = new List<Branch>()
        {
            new Branch(){ID=1,BranchName="Matematik"},
            new Branch(){ID=2,BranchName="Türkçe"},
            new Branch(){ID=3,BranchName="Fizik"},
        };
        public IActionResult AddTeacher()
        {
            ViewBag.Braches = branches;
            Teacher teacher = new Teacher() { FirstName="Abdullah",LastName="Ayhan",BranchId=2};
            return View(teacher);
        }

        [HttpPost]
        public IActionResult AddTeacher(Teacher teacher)
        {
            ViewBag.Braches = branches;
            return View();
        }

        public IActionResult AddTeacherUsingTuple()
        {
            (List<Branch>, Teacher,Student) tuple = (branches, new Teacher(),new Student());
            return View(tuple);
        }

        [HttpPost]
        public IActionResult AddTeacherUsingTuple([Bind(Prefix ="Item2")] Teacher teacher,
            [Bind(Prefix = "Item3")] Student student)
        {
            return RedirectToAction("AddTeacherUsingTuple");
        }
    }
}
