using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace MediatRExample.Handlers
{
    /// <summary>
    /// Our base request. This is what we send to MediatR. 
    /// We are expecting a string response.
    /// This response will just be an echo of what we send in.
    /// </summary>
    public class EchoRequest : IRequest<string> 
    {
        public string Message { get; set; }
    }

    /// <summary>
    /// Our EchoHandler is what handles EchoRequests. A string is returned.
    /// </summary>
    public class EchoHandler : IRequestHandler<EchoRequest, string>
    {
        public Task<string> Handle(EchoRequest request, CancellationToken cancellationToken)
        {
            return Task.FromResult(request.Message);
        }
    }
}
