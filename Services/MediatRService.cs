using System;
using System.Threading.Tasks;
using MediatR;
using MediatRExample.Handlers;

namespace MediatRExample.Services
{
    public class MediatRService : IMediatRService
    {
        private readonly IMediator _mediator;

        public MediatRService(IMediator mediator)
        {
            _mediator = mediator;
        }

        public async Task EchoRequest(string message)
        {
            var echoRequest = new EchoRequest
            {
                Message = message
            };

            // On request, the handler will pick up our request, and return our expected results.
            // We can then output that return string we're expecting.
            Console.WriteLine(await _mediator.Send(echoRequest));
        }

        public async Task CalculateSum(int num1, int num2)
        {
            var calculateSumRequest = new CalculateSumRequest
            {
                Num1 = num1,
                Num2 = num2
            };

            // Unlike our prior example, we're not expecting our message to come back. The request handles it all.
            await _mediator.Send(calculateSumRequest);
        }

        public async Task EchoNotification(string message)
        {
            var echoNotificationRequest = new EchoNotificationRequest
            {
                Message = message
            };

            // Unlike with our normal requests, with a notification request we publish,
            // allowing MediatR to loop through handlers, awaiting, and ensuring they are run in order.
            await _mediator.Publish(echoNotificationRequest);
        }
    }
}