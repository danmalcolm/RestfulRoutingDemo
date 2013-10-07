using System.Web.Mvc;

namespace RestfulRoutingDemo.WebApp.Controllers.Products
{
    public class ProductsController : DemoControllerBase
    {
        public ActionResult Index()
        {
            return DemoContent();
        }

        public ActionResult Show(string code)
        {
            return DemoContent();
        }

        public ActionResult Update(string code)
        {
            return DemoContent();
        }

        public ActionResult Create()
        {
            return DemoContent();
        }
    }
}