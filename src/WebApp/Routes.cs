using System.Web.Mvc;
using System.Web.Routing;
using RestfulRouting;
using RestfulRoutingDemo.WebApp.Controllers.Applications;
using RestfulRoutingDemo.WebApp.Controllers.Applications.Comments;
using RestfulRoutingDemo.WebApp.Controllers.Applications.Comments.Changes;
using RestfulRoutingDemo.WebApp.Controllers.Applications.Customer;
using RestfulRoutingDemo.WebApp.Controllers.Applications.Services;
using RestfulRoutingDemo.WebApp.Controllers.Home;
using RestfulRoutingDemo.WebApp.Controllers.Products;
using RestfulRoutingDemo.WebApp.Controllers.Products.Reviews;


[assembly: WebActivator.PreApplicationStartMethod(typeof(RestfulRoutingDemo.WebApp.Routes), "Start")]

namespace RestfulRoutingDemo.WebApp
{
    public class Routes : RouteSet
    {
        public static void Start()
        {
            var routes = RouteTable.Routes;
            routes.MapRoutes<Routes>();
        }

        public override void Map(IMapper map)
        {
            map.DebugRoute("routedebug");
            
            // Map root url
            map.Root<HomeController>(x => x.Index());
            
            // Applications entity and nested properties
            map.Resources<ApplicationsController>(applications =>
            {
                applications.As("applications");

                // Nested property - customer. 
                // The id of the parent entity is available to child controller actions as applicationId
                applications.Resource<CustomerController>();

                // Another nested property - list of services selected
                // Note that, although named in the plural, the collection of items
                // is still a single resource as the items are addressed as a whole.
                // Note that without the .As override, the library would attempt to 
                // convert Services to singular form.
                applications.Resource<ServicesController>(services =>
                    {
                        services.As("services");
                        // Limits the routes registered (if you have hundreds of controllers you might want to reduce
                        // the number of routes stored in RouteTable)
                        services.Only("show", "edit", "update"); 
                    });

                // Nested collection - comments
                applications.Resources<CommentsController>(comments =>
                    {
                        // Collection nested within a collection, the ids of parent entities are added
                        comments.Resources<ChangesController>();
                    });
            });


            // Product entity (using custom id parameter) and nested properties
            map.Resources<ProductsController>(products =>
                {
                    products.IdParameter("code");

                    products.Resources<ReviewsController>();
                });

            // Top level services entity - There are 2 controllers named ServicesController, but the routes
            // are registered using namespaces.
            map.Resources<ServicesController>(services => services.As("services"));


            // Add boring routes
            map.Route(new Route("{controller}/{action}/{id}", new RouteValueDictionary(new { action = "index" }), new MvcRouteHandler()));
            map.Route(new Route("{controller}/{action}", new RouteValueDictionary(new { action = "index" }), new MvcRouteHandler()));
            
        }
        
    }
}