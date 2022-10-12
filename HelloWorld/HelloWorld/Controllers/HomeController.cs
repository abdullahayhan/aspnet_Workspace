using Microsoft.AspNetCore.Mvc;

namespace HelloWorld.Controllers
{
    public class HomeController : Controller
    {
        public string Index()
        {
            return "Uygulama Çalışıyor";
        }

        public string Test()
        {
            return "bu test action";
        }

        public IActionResult Selamla()
        {
            ViewResult result = View();
            return result;
        }

        public IActionResult Selamla2()
        {
            ViewResult result = View("Test2");
            return result;
        }
    }
}
