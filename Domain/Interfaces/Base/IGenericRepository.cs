﻿using System.Linq.Expressions;

namespace gRPC_Service.Domain.Interfaces.Base
{
    public interface IGenericRepository<T> where T : class
    {
        Task<IEnumerable<T>> All();
        Task<T> GetById(Guid id);
        Task<T> Add(T entity);
        Task<bool> Delete(Guid id);
        Task<bool> Upsert(T entity);
        IQueryable<T> Find(Expression<Func<T, bool>> predicate);
    }
}
