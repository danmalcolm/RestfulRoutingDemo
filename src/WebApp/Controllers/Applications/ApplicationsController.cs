using System.Web.Mvc;

namespace RestfulRoutingDemo.WebApp.Controllers.Applications
{
    public class ApplicationsController : DemoControllerBase
    {
        public ActionResult Index()
        {
            return DemoContent();
        }

        public ActionResult Show(string id)
        {
            return DemoContent();
        }

        public ActionResult Update(string id)
        {
            return DemoContent();
        }

        public ActionResult Create()
        {
            return DemoContent();
        }
    }
}