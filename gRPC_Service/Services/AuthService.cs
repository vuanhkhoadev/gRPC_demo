using Grpc.Core;
using gRPC_Service;
using gRPC_Service.API.Application.User.Command.RegisterNewUser;
using gRPC_Service.API.Application.User.Command.RegisterNewUser.Models;
using gRPC_Service.Services;
using MediatR;

namespace gRPC_Service.API.Services
{
    public class AuthService: Auth.AuthBase
    {
        private readonly ILogger<AuthService> _logger;
        private readonly IMediator _mediator;

        public AuthService(ILogger<AuthService> logger, IMediator mediator)
        {
            _logger = logger;
            _mediator = mediator;
        }

        public override async Task<RegisterResponse> Register(RegisterRequest request, ServerCallContext context)
        {
            var model = new RegisterNewUserModel()
            {
                Username = request.Username,
                Password = request.Password
            };

            var result = await _mediator.Send(new RegisterNewUserCommand(model));


            return new RegisterResponse
            {
                Message = result.Message,
                IsSuccess = result.IsSuccess
            };
        }
    }
}
