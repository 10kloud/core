using _10kloud_AppCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10kloud_AppCore.Interfaces.Services
{
    /// <summary>
    /// it's the alarms service intarface for the CRUD Methods 
    /// </summary>
    public interface IServiceAlarms
    {
        IEnumerable<Alarm> GetAlarms();

        Alarm Get(int id);
        void Delete(int id);

        IEnumerable<Alarm> GetByAlarmingParameter(string AlarmingParameter);

        void Insert(Alarm item);
        void Update(Alarm item);
    }
}
