using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10kloud_AppCore.Entities
{
    /// <summary>
    /// Alarm class contain the database's attributes
    /// the primary key id is ereditated from Entity base
    /// </summary>
    public class Alarm : Entity<int>
    {
        /// <summary>
        /// Silos Identifier
        /// </summary>
        [Display(Name = "Silos")]
        public int Silos_Id { get; set; }

        public string Name { get; set; }


        public string Description { get; set; }


        /// <summary>
        /// Threshold of the Alarm
        /// </summary>  
        [Display(Name = "Soglia Di Allarme")]
        public double Threshold { get; set; }
        /// <summary>
        /// sensor checked by the Alarm
        /// </summary>
        [Display(Name = "Parametro Dell'Allarme")]
        public string Alarming_Parameter { get; set; }

        /// <summary>
        /// severity of the alarm( information, error, danger etc..)
        /// </summary>
        [Display(Name = "Gravità Allarme")]
        public int Severity_Alarm { get; set; }

        /// <summary>
        /// User that created the Alarm
        /// </summary>
        [Display(Name = "Email Utente")]
        public string User_Email { get; set; }

    }
}
