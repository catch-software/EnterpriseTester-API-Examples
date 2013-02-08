using System.ComponentModel.Composition;
using Castle.MicroKernel.Registration;
using EnterpriseTester.Common.Plugins;
using MonoRail.ModuleFramework.Modules;

namespace EnterpriseTester.Plugins.RaygunIO
{
    [PluginDetails(
        Name = "Raygun IO Exception Handling",
        Description = "Provides logging of unhandled exception to RaygunIO",
        VendorName = "Catch Software",
        VendorUrl = "http://www.catchsoftware.com/",
        InitialState = InitialiModuleState.Enabled)]
    [Export(typeof (IPluginInstaller))]
    public class RaygunPluginInstaller : AbstractPluginInstaller
    {
        public override void Install(InstallationHelper helper)
        {
            helper.Register(Component.For<RaygunClientExecutor>());
            helper.Register(Component.For<UnahandledExceptionRaygunRelayer>());
            helper.Register(Component.For<RaygunLog4NetAppenderInstaller>());
            helper.Register(Component.For<EnterpriseTesterRaygunMessageBuilderFactory>());
        }
    }
}