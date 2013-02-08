using System;
using EnterpriseTester.Common.Application;
using Mindscape.Raygun4Net.Messages;
using MonoRail.ModuleFramework.Facilities.EventPublisher;

namespace EnterpriseTester.Plugins.RaygunIO
{
    public class UnahandledExceptionRaygunRelayer : IListener<UnhandledException>
    {
        readonly RaygunClientExecutor _clientExecutor;
        readonly EnterpriseTesterRaygunMessageBuilderFactory _messageBuilderFactory;

        public UnahandledExceptionRaygunRelayer(RaygunClientExecutor clientExecutor, EnterpriseTesterRaygunMessageBuilderFactory messageBuilderFactory)
        {
            if (clientExecutor == null) throw new ArgumentNullException("clientExecutor");
            if (messageBuilderFactory == null) throw new ArgumentNullException("messageBuilderFactory");
            _clientExecutor = clientExecutor;
            _messageBuilderFactory = messageBuilderFactory;
        }

        public void Handle(UnhandledException subject)
        {
            RaygunMessage message = _messageBuilderFactory.CreateBuilder().SetException(subject.Exception).Build();
            _clientExecutor.Execute(client => client.SendInBackground(message));
        }
    }
}