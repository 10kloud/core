using _10kloud_AppCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10kloud_AppCore.Interfaces.Services
{
    /// <summary>
    /// it's the users service intarface for the CRUD Methods 
    /// </summary>
    public interface IServiceUsers
    {
        IEnumerable<User> GetUsers();

        User Get(int id);
        void Delete(string id);


        void Insert(User item);
        void Update(User item);
    } 
}
