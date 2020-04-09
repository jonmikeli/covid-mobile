using System.IO;

using IoTSolution.API.IoC.Configuration.DI;
using IoTSolution.API.Tools.Configurations;

using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace IoTSolution.API.API.Tests.Controllers
{
    [TestClass]
    public class TestBase
    {
        internal IConfigurationRoot _configurationRoot;
        internal ServiceCollection _services;

        public TestBase()
        {
            _configurationRoot = ConfigurationHelper.GetIConfigurationRoot(Directory.GetCurrentDirectory());

            _services = new ServiceCollection();

            //We load EXACTLY the same settings (DI and others) than API real solution, what is much better for tests.
            _services.ConfigureBusinessServices((IConfiguration)_configurationRoot);
        }
    }
}
