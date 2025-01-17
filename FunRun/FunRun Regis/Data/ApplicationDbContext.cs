using Microsoft.AspNetCore.Mvc;

namespace FunRun_Regis
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
