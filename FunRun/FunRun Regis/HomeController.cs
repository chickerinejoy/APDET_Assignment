public class HomeController : Controller
{
    // This is the action for Home
    public IActionResult Index()
    {
        return View();
    }

    // This is the action for Terms and Conditions
    public IActionResult TermsAndConditions()
    {
        return View();
    }
}
