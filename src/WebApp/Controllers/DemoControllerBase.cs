using System.Web.Mvc;
using Newtonsoft.Json;

namespace RestfulRoutingDemo.WebApp.Controllers
{
    public class DemoControllerBase : Controller
    {
        protected ActionResult DemoContent()
        {
            var routeValues = RouteData.Values;
            var model = new DemoModel
                {
                    Controller = routeValues["controller"].ToString(),
                    ControllerType = ControllerContext.Controller.GetType().FullName,
                    Action = routeValues["action"].ToString(),
                    RouteValueSummary = JsonConvert.SerializeObject(routeValues)
                };
            return View("Index", model);
        }
    }
}