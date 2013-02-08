using Castle.Core;
using log4net;
using log4net.Core;
using log4net.Repository.Hierarchy;

namespace EnterpriseTester.Plugins.RaygunIO
{
    public class RaygunLog4NetAppenderInstaller : IStartable
    {
        readonly RaygunLog4NetAppender _appender;

        public RaygunLog4NetAppenderInstaller(RaygunClientExecutor clientExecutor, EnterpriseTesterRaygunMessageBuilderFactory messageBuilderFactory)
        {
            _appender = new RaygunLog4NetAppender(clientExecutor, messageBuilderFactory);
        }

        public void Start()
        {
            IAppenderAttachable attachable = GetAppenderAttachable();
            if (attachable != null) attachable.AddAppender(_appender);
        }

        public void Stop()
        {
            IAppenderAttachable attachable = GetAppenderAttachable();
            if (attachable != null) attachable.RemoveAppender(_appender);
        }

        static IAppenderAttachable GetAppenderAttachable()
        {
            Logger root = ((Hierarchy) LogManager.GetRepository()).Root;
            var attachable = root as IAppenderAttachable;
            return attachable;
        }
    }
}