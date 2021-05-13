using _10kloud_AppCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10kloud_AppCore.Interfaces.Repository
{

    /// <summary>
    /// Repository base it's made up to be ereditated by repository interfaces
    /// it ties entity to their primary key
    /// also contains CRUD method
    /// </summary>
    /// <typeparam name="TEntity"></typeparam>
    /// <typeparam name="TPrimaryKey"></typeparam>
    public interface IRepositoryBase<TEntity, TPrimaryKey>
        where TEntity : Entity<TPrimaryKey>
    {
        /// <summary>
        /// get all
        /// </summary>
        /// <returns></returns>
        IEnumerable<TEntity> GetAll();
        /// <summary>
        /// get an Entitry by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        TEntity Get(TPrimaryKey id);

        /// <summary>
        /// insert a new Entity
        /// </summary>
        /// <param name="entity"></param>
        void Insert(TEntity entity);
        /// <summary>
        /// update an Entity
        /// </summary>
        /// <param name="entity"></param>
        void Update(TEntity entity);
        /// <summary>
        /// delete an Entity
        /// </summary>
        /// <param name="id"></param>
        void Delete(TPrimaryKey id);
    }
}
