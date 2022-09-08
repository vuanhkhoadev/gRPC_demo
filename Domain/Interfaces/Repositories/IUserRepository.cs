using gRPC_Service.Domain.Entities;
using gRPC_Service.Domain.Interfaces.Base;

namespace gRPC_Service.Domain.Interfaces.Repositories
{
    public interface IUserRepository : IGenericRepository<User>
    {
    }
}
