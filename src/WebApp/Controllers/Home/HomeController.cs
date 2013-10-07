using System.Web.Mvc;

namespace RestfulRoutingDemo.WebApp.Controllers.Home
{
    public class HomeController : DemoControllerBase
    {
         public ActionResult Index()
         {
             return DemoContent();
         }
    }
}