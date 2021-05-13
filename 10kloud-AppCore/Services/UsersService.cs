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
    public class UsersService : IServiceUsers
    {

        private readonly IRepositoryUsers _repositoryUsers;

        public UsersService(IRepositoryUsers repositoryUsers)
        {
            _repositoryUsers = repositoryUsers;
        }

        public void Delete(int id)
        {
            _repositoryUsers.Delete(id);
        }

        public User Get(int id)
        {
            return _repositoryUsers.Get(id);
        }

        public IEnumerable<User> GetUsers()
        {
            return _repositoryUsers.GetAll();
        }

        public void Insert(User item)
        {
            _repositoryUsers.Insert(item);
        }

        public void Update(User item)
        {
            _repositoryUsers.Update(item);
        }
    }
}
