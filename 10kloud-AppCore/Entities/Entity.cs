using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10kloud_AppCore.Entities
{

    /// <summary>
    /// Id is made up to be the primary key of the entities
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public abstract class Entity<T>
    {
        
        public T Id { get; set; }
    }
}
