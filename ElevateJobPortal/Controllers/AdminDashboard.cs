using Microsoft.AspNetCore.Mvc;

namespace ElevateJobPortal.Controllers
{
    public class AdminDashboard : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
