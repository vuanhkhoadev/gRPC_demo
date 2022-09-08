using gRPC_Service.Domain.Context;
using gRPC_Service.Domain.Entities;
using gRPC_Service.Domain.Interfaces;
using gRPC_Service.Domain.Interfaces.Repositories;
using gRPC_Service.Infrastructure.Implements.Repositories;
using Microsoft.Extensions.Logging;

namespace gRPC_Service.Infrastructure.Implements
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private readonly TheaterDbContext _context;
        private readonly ILogger<UnitOfWork> _logger;

        public IUserRepository UserRepository { get; private set; }
        public IUserInformationRepository UserInformationRepository { get; private set; }

        public UnitOfWork(TheaterDbContext context, ILogger<UnitOfWork> logger)
        {
            _context = context;
            _logger = logger;

            UserRepository = new UserRepository(context, _logger);
            UserInformationRepository = new UserInformationRepository(context, _logger);
        }

        public async Task CompleteAsync()
        {
            await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
