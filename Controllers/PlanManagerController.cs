using Microsoft.AspNetCore.Mvc;

namespace SPRM_FRAMEWORK.Controllers
{
    public class PlanManagerController : BaseController
    {
        public PlanManagerController(IConfiguration config) : base(config) { }
        public IActionResult Grid()
        {
            return View();
        }
        public IActionResult Gantt()
        {
            return View();
        }
        public IActionResult Kanban()
        {
            return View();
        }
        public IActionResult Calendar()
        {
            return View();
        }
        public IActionResult Graph()
        {
            return View();
        }
    }
}
