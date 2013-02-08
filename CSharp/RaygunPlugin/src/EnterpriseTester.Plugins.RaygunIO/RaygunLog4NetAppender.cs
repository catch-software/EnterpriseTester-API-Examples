using System;
using Mindscape.Raygun4Net.Messages;
using log4net.Appender;
using log4net.Core;

namespace EnterpriseTester.Plugins.RaygunIO
{
    public class RaygunLog4NetAppender : AppenderSkeleton
    {
        readonly RaygunClientExecutor _clientExecutor;
        readonly EnterpriseTesterRaygunMessageBuilderFactory _messageBuilderFactory;

        public RaygunLog4NetAppender(RaygunClientExecutor clientExecutor, EnterpriseTesterRaygunMessageBuilderFactory messageBuilderFactory)
        {
            if (clientExecutor == null) throw new ArgumentNullException("clientExecutor");
            if (messageBuilderFactory == null) throw new ArgumentNullException("messageBuilderFactory");
            _clientExecutor = clientExecutor;
            _messageBuilderFactory = messageBuilderFactory;
        }

        protected override void Append(LoggingEvent loggingEvent)
        {
            if (IsErrorOrGreaterWithExceptionObject(loggingEvent))
            {
                RaygunMessage message = _messageBuilderFactory.CreateBuilder().SetException(loggingEvent.ExceptionObject).SetLog4NetInfo(loggingEvent).Build();
                _clientExecutor.Execute(client => client.SendInBackground(message));
            }
        }

        static bool IsErrorOrGreaterWithExceptionObject(LoggingEvent loggingEvent)
        {
            return loggingEvent.ExceptionObject != null && loggingEvent.Level >= Level.Error;
        }
    }
}