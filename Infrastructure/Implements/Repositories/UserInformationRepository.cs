using gRPC_Service.Domain.Context;
using gRPC_Service.Domain.Entities;
using gRPC_Service.Domain.Interfaces.Base;
using gRPC_Service.Domain.Interfaces.Repositories;
using Microsoft.Extensions.Logging;

namespace gRPC_Service.Infrastructure.Implements.Repositories
{
    public class UserInformationRepository: GenericRepository<UserInformation>, IUserInformationRepository
    {
        public UserInformationRepository(TheaterDbContext context, ILogger logger) : base(context, logger) { }

    }
}
