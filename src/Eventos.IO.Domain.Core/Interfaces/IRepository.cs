using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Eventos.IO.Domain.Core;
using Eventos.IO.Domain.Core.Base;

namespace Eventos.IO.Domain.Core.Interface
{
    public interface IRepository<TEntity> : IDisposable where TEntity : Entity 
    {
        void Add(TEntity obj);
        TEntity Get(Guid id);
        IEnumerable<TEntity> List();
        void Update(TEntity entity);
        void Remove(Guid id);
        IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> preicate);
        bool Save();
    }
}