using MediatR;
using MediatRExample.Services;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Threading.Tasks;

namespace MediatRExample
{
    class Program
    {
        // Main entry point. We're doing some stuff ... and not messing with static, so we call 
        // our new Start method to handle configuration and execution.
        private static void Main() => new Program().Start().GetAwaiter().GetResult();

        public async Task Start()
        {
            // Configure DependencyInjection
            var provider = ConfigureServices();
            // Get an instance of our MediatR Service.
            var service = provider.GetRequiredService<IMediatRService>();

            // Execute our service requests.
            await service.EchoRequest("My test echo.");
            await service.CalculateSum(1, 2);
            await service.EchoNotification("My echo notification.");
        }

        public IServiceProvider ConfigureServices()
        {
            var services = new ServiceCollection()
                .AddScoped<IMediatRService, MediatRService>()
                // Adding MediatR, we add via typeof. 
                // (I believe) reflection is used to collect our requests/handlers
                // and do voodoo under the hood.
                .AddMediatR(typeof(Program));

            return services.BuildServiceProvider();
        }
    }
}
