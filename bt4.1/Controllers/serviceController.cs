using Microsoft.AspNetCore.Mvc;

namespace bt4._1.Controllers
{
    public class serviceController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
