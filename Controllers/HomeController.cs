using Microsoft.AspNetCore.Mvc;

namespace MVCApplicationIleZaIle.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            System.Console.WriteLine("HomeController - Index");
            return View();
        }
    }
}