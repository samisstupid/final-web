using Microsoft.AspNetCore.Mvc;

namespace ElevateJobPortal.Controllers
{
    public class JobDescriptionController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
