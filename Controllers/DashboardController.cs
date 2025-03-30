using Microsoft.AspNetCore.Mvc;

namespace SPRM_FRAMEWORK.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
