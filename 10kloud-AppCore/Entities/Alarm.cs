using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10kloud_AppCore.Entities
{
    /// <summary>
    /// Alarm class contain the database's attributes
    /// the primary key id is ereditated from Entity base
    /// </summary>
    public class Alarm:Entity<int>
    {
        /// <summary>
        /// Silos Identifier
        /// </summary>
        public int Silos_Id { get; set; }
        /// <summary>
        /// Threshold of the Alarm
        /// </summary>
        public double Threshold { get; set; }
        /// <summary>
        /// sensor checked by the Alarm
        /// </summary>
        public string Alarming_Parameter { get; set; }

        /// <summary>
        /// severity of the alarm( information, error, danger etc..)
        /// </summary>
        public int Serverity_Alarm { get; set; }

        /// <summary>
        /// User that created the Alarm
        /// </summary>
        public int User_Id { get; set; }

    }
}
