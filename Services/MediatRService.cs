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

            Console.WriteLine(await _mediator.Send(echoRequest));
        }

        public async Task CalculateSum(int num1, int num2)
        {
            var calculateSumRequest = new CalculateSumRequest
            {
                Num1 = num1,
                Num2 = num2
            };

            await _mediator.Send(calculateSumRequest);
        }

        public async Task EchoNotification(string message)
        {
            var echoNotificationRequest = new EchoNotificationRequest
            {
                Message = message
            };

            await _mediator.Publish(echoNotificationRequest);
        }
    }
}