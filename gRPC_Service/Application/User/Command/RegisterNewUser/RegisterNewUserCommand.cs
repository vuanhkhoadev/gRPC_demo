using gRPC_Service.API.Application.User.Command.RegisterNewUser.Models;
using MediatR;

namespace gRPC_Service.API.Application.User.Command.RegisterNewUser
{
    public class RegisterNewUserCommand: IRequest<RegisterNewUserResult>
    {
        public RegisterNewUserModel Model { get; set; }
        public RegisterNewUserCommand(RegisterNewUserModel model)
        {
            Model = model;
        }
    }
}
