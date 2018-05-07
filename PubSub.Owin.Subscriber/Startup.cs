using Microsoft.Owin;
using Owin;
using SimpleInjector;
using SimpleInjector.Integration.WebApi;
using SimpleInjector.Lifestyles;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Web.Http;

[assembly: OwinStartup(typeof(PubSub.Owin.Subscriber.Startup))]

namespace PubSub.Owin.Subscriber
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            var container = new Container();
            container.Options.DefaultScopedLifestyle = new AsyncScopedLifestyle();

            Assembly assembly = Assembly.GetExecutingAssembly();
            string binFolder = Path.GetDirectoryName(assembly.Location);
            var assemblies = from file in new DirectoryInfo(binFolder).GetFiles()
                             where file.Name.StartsWith("PubSub") && file.Extension.ToLower() == ".dll"
                             select Assembly.Load(AssemblyName.GetAssemblyName(file.FullName));
            container.RegisterPackages(assemblies);

            HttpConfiguration config = new HttpConfiguration();

            container.RegisterWebApiControllers(config);
            container.Verify();

            config.DependencyResolver = new SimpleInjectorWebApiDependencyResolver(container);

            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
            
            app.UseWebApi(config);            
        }
    }
}
