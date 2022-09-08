using AutoMapper;
using gRPC_Service.API.Application.User.Command.RegisterNewUser.Models;
using gRPC_Service.API.Helpers;
using gRPC_Service.Domain.Interfaces;
using gRPC_Service.Infrastructure.Implements;
using MediatR;

namespace gRPC_Service.API.Application.User.Command.RegisterNewUser
{
    public class RegisterNewUserCommandHandler: IRequestHandler<RegisterNewUserCommand, RegisterNewUserResult>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IConfiguration _configuration;
        private readonly IMapper _mapper;
        public RegisterNewUserCommandHandler(IUnitOfWork unitOfWork, IConfiguration configuration, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _configuration = configuration;
            _mapper = mapper;
        }

        public async Task<RegisterNewUserResult> Handle(RegisterNewUserCommand command, CancellationToken cancellationToken)
        {
            try
            {
                var user = _mapper.Map<gRPC_Service.Domain.Entities.User>(command.Model);
                string password = command.Model.Password;
                user.CreateUserPassword(password);

                var createdUser = await _unitOfWork.UserRepository.Add(user);
                await _unitOfWork.CompleteAsync();

                return new RegisterNewUserResult
                {
                    IsSuccess = true,
                    Message = "Success",
                    
                };
            }
            catch(Exception ex)
            {
                return new RegisterNewUserResult
                {
                    IsSuccess = false,
                    Message = ex.Message,

                };
            }

        }
    }
}
