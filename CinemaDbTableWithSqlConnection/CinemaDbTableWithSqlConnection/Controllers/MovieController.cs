using CinemaDbTableWithSqlConnection.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CinemaDbTableWithSqlConnection.Controllers
{
    public class MovieController : Controller
    {
        CinemaDBContext _db;
        public MovieController(CinemaDBContext db)
        {
            _db = db;
        }
        public IActionResult List()
        {
            List<Movie> movies = _db.Movies.ToList();
            return View(movies);
        }
    }
}
