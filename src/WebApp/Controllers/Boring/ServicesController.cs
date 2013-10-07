using System.Web.Mvc;

namespace RestfulRoutingDemo.WebApp.Controllers.Boring
{
    public class BoringController : DemoControllerBase
    {
        public ActionResult Index()
        {
            return DemoContent();
        }

        public ActionResult Action2()
        {
            return DemoContent();
        }
    }
}