using System.Web.Mvc;

namespace RestfulRoutingDemo.WebApp.Controllers.Applications.Comments
{
    public class CommentsController : DemoControllerBase
    {
        public ActionResult Index(string applicationId)
        {
            return DemoContent();
        }

        public ActionResult Show(string applicationId, string id)
        {
            return DemoContent();
        }
    }
}