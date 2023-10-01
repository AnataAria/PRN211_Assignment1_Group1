using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;

namespace Repositories
{
    public interface IRepository<TEntity> where TEntity : class
    {
        TEntity Get(BigInteger id);
        IEnumerable<TEntity> GetAll();
        TEntity Add(TEntity entity);
        TEntity Update(TEntity entity);
        TEntity Delete(BigInteger id);
    }
}