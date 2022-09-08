using gRPC_Service.Domain.Interfaces.Repositories;

namespace gRPC_Service.Domain.Interfaces
{
    public interface IUnitOfWork
    {
        IUserRepository UserRepository { get; }
        IUserInformationRepository UserInformationRepository { get; }
        Task CompleteAsync();
    }
}
