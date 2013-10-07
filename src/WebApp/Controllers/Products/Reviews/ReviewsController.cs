using System.Web.Mvc;

namespace RestfulRoutingDemo.WebApp.Controllers.Products.Reviews
{
    public class ReviewsController : DemoControllerBase
    {
        public ActionResult Index(string productCode)
        {
            return DemoContent();
        }

        public ActionResult Show(string productCode, string id)
        {
            return DemoContent();
        }
    }
}