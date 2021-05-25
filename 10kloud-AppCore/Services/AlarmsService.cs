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
    /// this service redirect all call from the webapp to the repository made with the dependency injection
    /// 
    /// </summary>
    public class AlarmsService : IServiceAlarms
    {
        /// <summary>
        /// dependency injection
        /// </summary>
        private readonly IRepositoryAlamrs _alarmsRepository;

        /// <summary>
        /// constructor
        /// </summary>
        /// <param name="alarmsRepository"></param>
        public AlarmsService(IRepositoryAlamrs alarmsRepository)
        {
            _alarmsRepository = alarmsRepository;
        }

        /// <summary>
        /// Delete an Alarm by id
        /// </summary>
        /// <param name="id"></param>
        public void Delete(int id)
        {
            _alarmsRepository.Delete(id);
        }

        /// <summary>
        /// get an Alarm by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Alarm Get(int id)
        {
            return _alarmsRepository.Get(id);
        }

        /// <summary>
        /// get all Alarms
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Alarm> GetAlarms()
        {
            return _alarmsRepository.GetAll();
        }

        public IEnumerable<Alarm> GetByAlarmingParameter(string AlarmingParameter)
        {
            return _alarmsRepository.GetByAlarmingParameter(AlarmingParameter);
        }

        /// <summary>
        /// Insert a new Alarm
        /// </summary>
        /// <param name="item"></param>
        public void Insert(Alarm item, string AlarmingParameter)
        {
            _alarmsRepository.Insert(item);
        }

        /// <summary>
        /// Update an alarm
        /// </summary>
        /// <param name="item"></param>
        public void Update(Alarm item)
        {
            _alarmsRepository.Update(item);
        }
    }
}
