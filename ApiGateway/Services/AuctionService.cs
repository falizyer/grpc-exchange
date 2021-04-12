using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FixProtocol.Core;
using Grpc.Core;
using Microsoft.Extensions.Logging;

namespace ApiGateway.Services
{
    public class AuctionService : Auction.AuctionBase
    {
        private readonly ILogger<HealthCheckService> _logger;

        public AuctionService(ILogger<HealthCheckService> logger)
        {
            _logger = logger;
        }

        public override Task<OrderResponse> SubmitOrder(OrderRequest request, ServerCallContext context)
        {
            _logger.Log(LogLevel.Debug,
                $"HealthCheckService:SubmitOrder[MessageType:NewOrder:{OrderRequest.Types.MessageType.NewOrder}]");
            return Task.FromResult(new OrderResponse { });
        }
    }
}