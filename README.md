[![.NET](https://github.com/MattTheDev/MediatRExample/actions/workflows/dotnet.yml/badge.svg)](https://github.com/MattTheDev/MediatRExample/actions/workflows/dotnet.yml)

# Example of a MediatR Implementation

Implementing and Utilizing MediatR, a simple .NET mediator implementation.

Code should be documented enough to understand the implmentation. However, the main entry point is:

```csharp
await service.EchoRequest("My test echo.");
await service.CalculateSum(1, 2);
await service.EchoNotification("My echo notification.");
```

These 3 lines execute methods implemented in `MediatRService.cs`, creating our MediatR requests, which are then routed through MediatR.

Examples of Usage:

1. Request with no response.
2. Request with a response.
3. Notification request with multiple handlers.

The real MVP here? Jimmy Bogard

MediatR GitHub Repo: [https://github.com/jbogard/MediatR](https://github.com/jbogard/MediatR)   
Jimmy's GitHub Profile: [https://github.com/jbogard](https://github.com/jbogard)
