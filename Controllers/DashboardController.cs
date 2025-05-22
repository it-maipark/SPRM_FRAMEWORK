using Microsoft.AspNetCore.Mvc;

namespace SPRM_FRAMEWORK.Controllers
{
    public class DashboardController : BaseController
    {
        public DashboardController(IConfiguration config) : base(config) { }
        public IActionResult Index()
        {
            return View();
        }
    }
}
