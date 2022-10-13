using GettingData.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GettingData.Controllers
{
    public class StudentController : Controller
    {
        List<Student> students = new List<Student>() 
        {
            new Student(){firstName="Abdullah",lastName="Ayhan"},
            new Student(){firstName="Mert",lastName="Ayhan"},
            new Student(){firstName="Elif",lastName="Ayhan"},
            new Student(){firstName="Çidem",lastName="Ayhan"},
        };

        public IActionResult GettAllStudent()
        {
            return View(students);
        }

        [HttpPost]
        public IActionResult AddStudent(Student student)
        {
            students.Add(student);
            return View("GettAllStudent",students);
        }
    }
}
