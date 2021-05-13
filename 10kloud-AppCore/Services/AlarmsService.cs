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
    public class AlarmsService : IServiceAlarms
    {
        private readonly IRepositoryAlamrs _alarmsRepository;

        public AlarmsService(IRepositoryAlamrs alarmsRepository)
        {
            _alarmsRepository = alarmsRepository;
        }

        public void Delete(int id)
        {
            _alarmsRepository.Delete(id);
        }

        public Alarm Get(int id)
        {
            return _alarmsRepository.Get(id);
        }

        public IEnumerable<Alarm> GetAlarms()
        {
            return _alarmsRepository.GetAll();
        }

        public void Insert(Alarm item)
        {
            _alarmsRepository.Insert(item);
        }

        public void Update(Alarm item)
        {
            _alarmsRepository.Update(item);
        }
    }
}
