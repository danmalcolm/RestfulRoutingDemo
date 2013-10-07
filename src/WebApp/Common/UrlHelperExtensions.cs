using System;
using System.Linq.Expressions;
using System.Web.Mvc;

namespace RestfulRoutingDemo.WebApp.Common
{
    public static class UrlHelperExtensions
    {
        /// <summary>
        /// Generates URL for action based on action expression
        /// </summary>
        /// <typeparam name="TController"></typeparam>
        /// <param name="urlHelper"></param>
        /// <param name="expression"></param>
        /// <param name="additionalRouteValues"></param>
        /// <param name="protocol"></param>
        /// <returns></returns>
        public static string Action<TController>(this UrlHelper urlHelper, Expression<Action<TController>> expression,
                                                 object additionalRouteValues = null, string protocol = "http")
            where TController : Controller
        {
            var routeValues = Microsoft.Web.Mvc.Internal.ExpressionHelper.GetRouteValuesFromExpression(expression);
            var controller = routeValues["controller"].ToString();
            var action = routeValues["action"].ToString();

            //routeValues.MergeFrom(additionalRouteValues);

            return urlHelper.Action(action, controller, routeValues, protocol, null);
        }
    }
}