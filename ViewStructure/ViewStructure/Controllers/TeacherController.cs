using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ViewStructure.Models;

namespace ViewStructure.Controllers
{
    public class TeacherController : Controller
    {
        List<Teacher> teachers = new List<Teacher>() 
        {
            new Teacher(){ID=1,Name="Abdullah",Gender="man"},
            new Teacher(){ID=3,Name="Mert",Gender="man"},
            new Teacher(){ID=4,Name="Selin",Gender="woman"},
            new Teacher(){ID=5,Name="Merve",Gender="woman"},
        };
        public IActionResult GetTeacherList()
        {
            return View(teachers);
        }

        public IActionResult DeleteTeacher(int id)
        {
            Teacher teacher = teachers.Find(x => x.ID == id);
            return View(teacher);
        }
    }
}
