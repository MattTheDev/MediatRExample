using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace MediatRExample.Handlers
{
    /// <summary>
    /// Our base request, an example of an implementation of INotification.
    /// Nothing is returned, but with INotifications, you can take action across
    /// multiple handlers.
    /// </summary>
    public class EchoNotificationRequest : INotification
    {
        public string Message { get; set; }
    }

    /// <summary>
    /// This is our first implementation of INotificationHandler.
    /// This simple implementation just outputs the data in a numbered list.
    /// </summary>
    public class EchoNotificationHandlerOne : INotificationHandler<EchoNotificationRequest>
    {
        public Task Handle(EchoNotificationRequest notification, CancellationToken cancellationToken)
        {
            Console.WriteLine($"1. {notification.Message}");

            return Task.CompletedTask;
        }
    }

    /// <summary>
    /// This is our second implementation of INotificationHandler.
    /// This simple implementation just outputs the data in a numbered list.
    /// </summary>
    public class EchoNotificationHandlerTwo : INotificationHandler<EchoNotificationRequest>
    {
        public Task Handle(EchoNotificationRequest notification, CancellationToken cancellationToken)
        {
            Console.WriteLine($"2. {notification.Message}");

            return Task.CompletedTask;
        }
    }
}