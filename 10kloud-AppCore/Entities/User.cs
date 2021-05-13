using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10kloud_AppCore.Entities
{
    /// <summary>
    /// User class contain the database's attributes
    /// the primary key id is ereditated from Entity base
    /// </summary>
    public class User : Entity<int>
    {
        /// <summary>
        /// user Email
        /// </summary>
        public string Email { get; set; }
        /// <summary>
        /// User Password
        /// </summary>
        public string Password { get; set; }
        /// <summary>
        /// User Permission
        /// </summary>
        public int Permission { get; set; }
    }
}
