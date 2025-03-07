using Microsoft.AspNetCore.Mvc;

namespace ElevateJobPortal.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
