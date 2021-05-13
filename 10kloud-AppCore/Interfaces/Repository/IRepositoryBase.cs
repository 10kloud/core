using _10kloud_AppCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10kloud_AppCore.Interfaces.Repository
{
    public interface IRepositoryBase<TEntity, TPrimaryKey>
        where TEntity : Entity<TPrimaryKey>
    {
        IEnumerable<TEntity> GetAll();
        TEntity Get(TPrimaryKey id);
        void Insert(TEntity entity);
        void Update(TEntity entity);
        bool Delete(TPrimaryKey id);
    }
}
