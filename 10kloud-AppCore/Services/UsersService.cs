using _10kloud_AppCore.Entities;
using _10kloud_AppCore.Interfaces.Repository;
using _10kloud_AppCore.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10kloud_AppCore.Services
{
    /// <summary>
    ///  this service redirect all call from the webapp to the repository made with the dependency injection
    /// </summary>
    public class UsersService : IServiceUsers
    {
        /// <summary>
        /// dependency injection
        /// </summary>
        private readonly IRepositoryUsers _repositoryUsers;


        /// <summary>
        /// constructor
        /// </summary>
        /// <param name="repositoryUsers"></param>
        public UsersService(IRepositoryUsers repositoryUsers)
        {
            _repositoryUsers = repositoryUsers;
        }


        /// <summary>
        /// delete a User by id
        /// </summary>
        /// <param name="id"></param>
        public void Delete(string id)
        {
            _repositoryUsers.Delete(id);
        }
        /// <summary>
        /// read a User by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public User Get(string id)
        {
            return _repositoryUsers.Get(id);
        }

        public User Get(int id)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// get all Users
        /// </summary>
        /// <returns></returns>
        public IEnumerable<User> GetUsers()
        {
            return _repositoryUsers.GetAll();
        }

        /// <summary>
        /// Insert a new User 
        /// </summary>
        /// <param name="item"></param>
        public void Insert(User item)
        {
            _repositoryUsers.Insert(item);
        }


        /// <summary>
        /// Update a User
        /// </summary>
        /// <param name="item"></param>
        public void Update(User item)
        {
            _repositoryUsers.Update(item);
        }
    }
}
