using System.Web.Mvc;

namespace RestfulRoutingDemo.WebApp.Controllers.Applications.Services
{
    public class ServicesController : DemoControllerBase
    {
        public ActionResult Index()
        {
            return DemoContent();
        }

        public ActionResult Show(string applicationId)
        {
            return DemoContent();
        }
    }
}