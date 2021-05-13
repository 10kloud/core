using _10kloud_AppCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10kloud_AppCore.Interfaces.Services
{
    public interface IServiceAlarms
    {
        IEnumerable<Alarm> GetAlarms();

        Alarm Get(int id);
        void Delete(int id);


        void Insert(Alarm item);
        void Update(Alarm item);
    }
}
