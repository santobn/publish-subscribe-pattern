using SimpleInjector;
using System.IO;
using System.Linq;
using System.Reflection;

namespace PubSub.Tests.Modules.Context
{
    public class SharedContainerTestContext
    {
        public readonly Container container;

        public SharedContainerTestContext()
        {
            container = new Container();

            string binFolder = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + @"\bin\debug";
            var assemblies = from file in new DirectoryInfo(binFolder).GetFiles()
                             where file.Name.StartsWith("PubSub") && file.Extension.ToLower() == ".dll"
                             select Assembly.Load(AssemblyName.GetAssemblyName(file.FullName));
            container.RegisterPackages(assemblies);

            container.Verify();
        }
    }
}
