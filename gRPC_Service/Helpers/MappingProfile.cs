using AutoMapper;
using gRPC_Service.API.Application.User.Command.RegisterNewUser.Models;
using gRPC_Service.Domain.Entities;

namespace gRPC_Service.API.Helpers
{
    public class MappingProfile: Profile
    {
        public MappingProfile()
        {
            CreateMap<RegisterNewUserModel, User>();
        }
    }
}
