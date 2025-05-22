using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace SPRM_FRAMEWORK.Controllers
{
    public class BaseController : Controller
    {
        protected readonly IConfiguration _config;

        public BaseController(IConfiguration config)
        {
            _config = config;
        }

        public override void OnActionExecuting(ActionExecutingContext context)
        {
            ViewBag.ApiBaseUrl = _config["Frontend:ApiBaseUrl"];
            base.OnActionExecuting(context);
        }
    }
}
