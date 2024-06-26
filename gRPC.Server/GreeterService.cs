﻿using System.Threading.Tasks;

using Greet;
using Grpc.Core;
using Microsoft.Extensions.Logging;
namespace gRPC.Server
{
    public class GreeterService:Greet.Greeter.GreeterBase
    {
        private readonly ILogger<GreeterService> _logger;

        public GreeterService(ILogger<GreeterService> logger)
        {
            _logger = logger;
        }

        public override Task<HelloReply> SayHello(HelloRequest request, ServerCallContext context)
        {
            return Task.FromResult(new HelloReply
            {
                Message = $"Hello, {request.Name}"
            });
        }
    }
}
