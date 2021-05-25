using _10kloud_AppCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10kloud_AppCore.Interfaces.Repository
{
    /// <summary>
    /// it ereditates from IRpeositoryBase all CRUD methods
    /// </summary>
    public interface IRepositoryAlamrs:IRepositoryBase<Alarm, int>
    {
        public IEnumerable<Alarm> GetByAlarmingParameter(string AlarmingParameter);


        void Insert(Alarm item, string AlarmingParameter, string user_email);
    }
}
