using MediatR;
using System;

namespace MediatRExample.Handlers
{
    /// <summary>
    /// Our base request. This is what gets sent to MediatR.
    /// Unlike EchoRequest, we're not expecting data to return.
    /// </summary>
    public class CalculateSumRequest : IRequest
    {
        public int Num1 { get; set; }
        public int Num2 { get; set; }
    }

    /// <summary>
    /// Our CalculateSumHandler is what handles CalculateSumRequests. Nothing is return.
    /// </summary>
    public class CalculateSumHandler : RequestHandler<CalculateSumRequest>
    {
        protected override void Handle(CalculateSumRequest request)
        {
            Console.WriteLine($"Sum of Numbers: {request.Num1 + request.Num2}");
        }
    }
}