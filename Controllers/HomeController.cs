using Microsoft.AspNetCore.Mvc;

namespace MVCApplicationIleZaIle.Controllers
{
    [Route("[controller]"), Route("/")]
    public class HomeController : Controller
    {
        [Route("[action]"), Route("")]
        public IActionResult Index()
        {
            System.Console.WriteLine("HomeController - Index!!!");
            return View();
        }
    }
}