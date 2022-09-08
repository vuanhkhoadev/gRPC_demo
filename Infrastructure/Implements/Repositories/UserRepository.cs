using gRPC_Service.Domain.Context;
using gRPC_Service.Domain.Entities;
using gRPC_Service.Domain.Interfaces.Base;
using gRPC_Service.Domain.Interfaces.Repositories;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gRPC_Service.Infrastructure.Implements.Repositories
{
    public class UserRepository : GenericRepository<User>, IUserRepository
    {
        public UserRepository(TheaterDbContext context, ILogger logger) : base(context, logger) { }
    }
}
