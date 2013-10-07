using System.Web.Mvc;

namespace RestfulRoutingDemo.WebApp.Controllers.Services
{
    public class ServicesController : DemoControllerBase
    {
        public ActionResult Index()
        {
            return DemoContent();
        }

        public ActionResult New()
        {
            return DemoContent();
        }

        public ActionResult Show(string id)
        {
            return DemoContent();
        } 

    }
}