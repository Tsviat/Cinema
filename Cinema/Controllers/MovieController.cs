using Microsoft.AspNetCore.Mvc;

namespace Cinema.Controllers
{
    public class MovieController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
