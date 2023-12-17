using Microsoft.AspNetCore.Mvc;

namespace AnotherMVCApp.Controllers
{
    public class HelloWorld : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
