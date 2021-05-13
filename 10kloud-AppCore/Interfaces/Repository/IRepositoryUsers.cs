using _10kloud_AppCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10kloud_AppCore.Interfaces.Repository
{
    /// <summary>
    /// it inherits  from IRepositoryBase
    /// </summary>
    public interface IRepositoryUsers:IRepositoryBase<User, int>
    {
    }
}
