using Microsoft.AspNetCore.Mvc;

namespace MoazAbuobida2dGames.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
