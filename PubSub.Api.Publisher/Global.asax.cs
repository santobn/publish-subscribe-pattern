using SimpleInjector;
using SimpleInjector.Integration.WebApi;
using SimpleInjector.Lifestyles;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Web.Http;

namespace PubSub.Api.Publisher
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            var container = new Container();
            container.Options.DefaultScopedLifestyle = new AsyncScopedLifestyle();

            var binFolder = Server.MapPath("~/bin");
            var assemblies = from file in new DirectoryInfo(binFolder).GetFiles()
                             where file.Name.StartsWith("PubSub") && file.Extension.ToLower() == ".dll"
                             select Assembly.Load(AssemblyName.GetAssemblyName(file.FullName));
            container.RegisterPackages(assemblies);

            container.RegisterWebApiControllers(GlobalConfiguration.Configuration);

            container.Verify();

            GlobalConfiguration.Configuration.DependencyResolver = new SimpleInjectorWebApiDependencyResolver(container);

            GlobalConfiguration.Configure(WebApiConfig.Register);
        }
    }
}
