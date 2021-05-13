using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10kloud_AppCore.Entities
{
    public class Alarm:Entity<int>
    {
        public int Silos_Id { get; set; }
        public double Threshold { get; set; }
        public string Alarming_Parameter { get; set; }
        public int Serverity_Alarm { get; set; }
        public int User_Id { get; set; }

    }
}
