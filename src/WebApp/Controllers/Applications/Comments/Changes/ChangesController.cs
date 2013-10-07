using System.Web.Mvc;

namespace RestfulRoutingDemo.WebApp.Controllers.Applications.Comments.Changes
{
    public class ChangesController : DemoControllerBase
    {
        public ActionResult Index(string applicationId, string commentId)
        {
            return DemoContent();
        }

        public ActionResult Show(string applicationId, string commentId, string id)
        {
            return DemoContent();
        }
    }
}