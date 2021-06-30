using MediatR;
using MediatRExample.Services;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Threading.Tasks;

namespace MediatRExample
{
    class Program
    {
        private static void Main() => new Program().Start().GetAwaiter().GetResult();

        public async Task Start()
        {
            var provider = ConfigureServices();
            var service = provider.GetRequiredService<IMediatRService>();

            await service.EchoRequest("My test echo.");
            await service.CalculateSum(1, 2);
            await service.EchoNotification("My echo notification.");
        }

        public IServiceProvider ConfigureServices()
        {
            var services = new ServiceCollection()
                .AddScoped<IMediatRService, MediatRService>()
                .AddMediatR(typeof(Program));

            return services.BuildServiceProvider();
        }
    }
}
