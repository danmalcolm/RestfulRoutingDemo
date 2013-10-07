using System.Web.Mvc;

namespace RestfulRoutingDemo.WebApp.Controllers.Applications.Customer
{
    public class CustomerController : DemoControllerBase
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