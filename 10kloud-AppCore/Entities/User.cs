using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10kloud_AppCore.Entities
{
    public class User : Entity<int>
    {
        public string Mail { get; set; }
        public string Password { get; set; }
        public int Permission { get; set; }
    }
}
