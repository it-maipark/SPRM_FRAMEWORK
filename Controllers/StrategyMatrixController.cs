using Microsoft.AspNetCore.Mvc;

namespace SPRM_FRAMEWORK.Controllers
{
    public class StrategyMatrixController : BaseController
    {
        public StrategyMatrixController(IConfiguration config) : base(config) { }
        public IActionResult Profitability()
        {
            return View();
        }

        public IActionResult Sustainability()
        {
            return View();
        }

        public IActionResult SDGs()
        {
            return View();
        }

        public IActionResult HCR()
        {
            return View();
        }

        public IActionResult Improvement()
        {
            return View();
        }
    }
}
