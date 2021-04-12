using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FixProtocol.Core;
using Grpc.Core;
using Microsoft.Extensions.Logging;

namespace ApiGateway.Services
{
    public class HealthCheckService : HealthCheck.HealthCheckBase
    {
        private readonly ILogger<HealthCheckService> _logger;

        public HealthCheckService(ILogger<HealthCheckService> logger)
        {
            _logger = logger;
        }

        public override Task<HeartbeatResponse> CheckHeartbeatRequest(HeartbeatRequest request,
            ServerCallContext context)
        {
            _logger.Log(LogLevel.Debug,
                $"HealthCheckService:CheckHeartbeatRequest[MessageType:Heartbeat:{HeartbeatRequest.Types.MessageType.Heartbeat}]");
            return Task.FromResult(new HeartbeatResponse { });
        }
        
        public override Task<TestRequestResponse> SendTestRequest(TestRequestRequest request,
            ServerCallContext context)
        {
            _logger.Log(LogLevel.Debug,
                $"HealthCheckService:SendTestRequest[TestRequest:Heartbeat:{TestRequestRequest.Types.MessageType.TestRequest}]");
            return Task.FromResult(new TestRequestResponse { });
        }
    }
}