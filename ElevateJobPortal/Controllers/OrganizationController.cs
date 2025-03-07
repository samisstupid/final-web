using Microsoft.AspNetCore.Mvc;

namespace ElevateJobPortal.Controllers
{
    public class OrganizationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
