using System.Threading.Tasks;

namespace MediatRExample.Services
{
    public interface IMediatRService
    {
        Task EchoRequest(string message);
        Task CalculateSum(int num1, int num2);
        Task EchoNotification(string message);
    }
}